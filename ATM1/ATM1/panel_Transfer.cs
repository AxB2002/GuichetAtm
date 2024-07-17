using ATM_App;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM1
{
	public partial class panel_Transfer : UserControl
	{
		public panel_Transfer()
		{
			InitializeComponent();
			LoadAccounts();
			LoadCheckingAccounts();
		}

		private void LoadAccounts()
		{
			string connectionString = UserContext.ConnectionStringWithDB;
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				string query = "SELECT AccountNumber, AccountType, Balance FROM Accounts WHERE ClientID = @ClientID ";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@ClientID", UserContext.CustomerID);

				try
				{
					connection.Open();
					MySqlDataReader reader = cmd.ExecuteReader();
					comboBox_toAcc.Items.Clear();
					comboBox_toAcc.SelectedIndex = -1;


					while (reader.Read())
					{
						int accountNumber = reader.GetInt32("AccountNumber");
						int accountType = reader.GetInt32("AccountType");
						decimal balance = reader.GetDecimal("Balance");
						Account account = CreateAccountInstance(accountType, accountNumber, balance);
						string displayText = $"{account.GetType().Name} - {account.AccountNumber} - Balance: {account.Balance:C}";

						comboBox_toAcc.Items.Add(new AccountInfo { Account = account, DisplayText = displayText });

					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error loading accounts: {ex.Message}");
				}
			}
		}

		private void LoadCheckingAccounts()
		{
			string connectionString = UserContext.ConnectionStringWithDB;
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				string query = "SELECT AccountNumber, AccountType, Balance FROM Accounts WHERE ClientID = @ClientID AND AccountType=1 ";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@ClientID", UserContext.CustomerID);

				try
				{
					connection.Open();
					MySqlDataReader reader = cmd.ExecuteReader();
					comboBox_fromAcc.Items.Clear();
					comboBox_fromAcc.SelectedIndex = -1;


					while (reader.Read())
					{
						int accountNumber = reader.GetInt32("AccountNumber");
						int accountType = reader.GetInt32("AccountType");
						decimal balance = reader.GetDecimal("Balance");
						Account account = CreateAccountInstance(accountType, accountNumber, balance);
						string displayText = $"{account.GetType().Name} - {account.AccountNumber} - Balance: {account.Balance:C}";

						comboBox_fromAcc.Items.Add(new AccountInfo { Account = account, DisplayText = displayText });

					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error loading accounts: {ex.Message}");
				}
			}
		}


		private Account CreateAccountInstance(int accountType, int accountNumber, decimal balance)
		{
			Account account = null;
			switch (accountType)
			{
				case 1: // Mortgage Account
					account = new CheckingAccount();
					break;
				case 2: // Checking Account
					account = new SavingsAccount();
					break;
				case 3: // Savings Account
					account = new MortgageAccount();
					break;
				case 4: // Line Of Credit Account
					account = new LineOfCreditAccount();
					break;
				default:
					throw new Exception("Unknown account type");
			}
			account.AccountNumber = accountNumber.ToString();
			account.Balance = balance;
			return account;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (comboBox_toAcc.SelectedItem is AccountInfo selectedAccountInfo && comboBox_fromAcc.SelectedItem is AccountInfo secondSelectedAccountInfo)
			{
				if (decimal.TryParse(textBox_Amount.Text, out decimal depositAmount))
				{
					secondSelectedAccountInfo.Account.Withdraw(depositAmount);
					if (comboBox_toAcc.Text.Contains("LineOfCreditAccount"))
					{
						selectedAccountInfo.Account.Withdraw(depositAmount);
					}
					else
					{
						selectedAccountInfo.Account.Deposit(depositAmount);
					}
					
					UpdateBalance(selectedAccountInfo.Account);
					UpdateBalance(secondSelectedAccountInfo.Account);
					LogTransaction(secondSelectedAccountInfo.Account.AccountNumber, selectedAccountInfo.Account.AccountNumber, depositAmount, TransactionType.Transfer);
				}
				else
				{
					MessageBox.Show("Please enter a valid deposit amount.");
				}
			}
			else
			{
				MessageBox.Show("Please select an account.");
			}
		}
		private void UpdateBalance(Account account)
		{
			string connectionString = UserContext.ConnectionStringWithDB;
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				string query = "UPDATE Accounts SET Balance = @Balance WHERE AccountNumber = @AccountNumber";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@Balance", account.Balance);
				cmd.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);

				try
				{
					connection.Open();
					int rowsAffected = cmd.ExecuteNonQuery();
					if (rowsAffected > 0)
					{
						MessageBox.Show("Deposit successful.");
						LoadCheckingAccounts();
						LoadAccounts(); // Reload accounts to reflect updated balance
					}
					else
					{
						MessageBox.Show("Error updating balance.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error updating balance: {ex.Message}");
				}
			}
		}
		private bool LogTransaction(string debitAccountNumber, string creditAccountNumber, decimal amount, TransactionType transactionType)
		{
			string connectionString = UserContext.ConnectionStringWithDB;
			string query = "INSERT INTO Transactions (TransactionDate, ClientID, DebitAccountNumber, CreditAccountNumber, Amount, TransactionType, Description)" +
						   " VALUES (@TransactionDate, @ClientID, @DebitAccountNumber, @CreditAccountNumber, @Amount, @TransactionType, @Description)";

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
				cmd.Parameters.AddWithValue("@ClientID", UserContext.CustomerID);
				cmd.Parameters.AddWithValue("@DebitAccountNumber", debitAccountNumber ?? (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@CreditAccountNumber", creditAccountNumber ?? (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@Amount", amount);
				cmd.Parameters.AddWithValue("@TransactionType", (int)transactionType);
				cmd.Parameters.AddWithValue("@Description", "Withdrawal");

				try
				{
					connection.Open();
					int rowsAffected = cmd.ExecuteNonQuery();
					return rowsAffected > 0; // Returns true if insertion was successful
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error logging transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
		}
	}
}
