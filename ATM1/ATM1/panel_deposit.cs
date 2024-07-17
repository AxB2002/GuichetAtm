using ATM_App;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ATM1
{
	public partial class panel_deposit : UserControl
	{
		public panel_deposit()
		{
			InitializeComponent();
			LoadAccounts();
		}

		private void LoadAccounts()
		{
			string connectionString = UserContext.ConnectionStringWithDB;
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				string query = "SELECT AccountNumber, AccountType, Balance FROM Accounts WHERE ClientID = @ClientID AND AccountType!=4";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@ClientID", UserContext.CustomerID);

				try
				{
					connection.Open();
					MySqlDataReader reader = cmd.ExecuteReader();
					comboBox_Accounts.Items.Clear();
					comboBox_Accounts.SelectedIndex = -1;
					comboBox_Accounts.Text = string.Empty;
					while (reader.Read())
					{
						int accountNumber = reader.GetInt32("AccountNumber");
						int accountType = reader.GetInt32("AccountType");
						decimal balance = reader.GetDecimal("Balance");
						Account account = CreateAccountInstance(accountType, accountNumber, balance);
						string displayText = $"{account.GetType().Name} - {account.AccountNumber} - Balance: {account.Balance:C}";
						
						comboBox_Accounts.Items.Add(new AccountInfo { Account = account, DisplayText = displayText });
						
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
			if (comboBox_Accounts.SelectedItem is AccountInfo selectedAccountInfo)
			{
				if (decimal.TryParse(textBox_Deposit_Amount.Text, out decimal depositAmount))
				{
					selectedAccountInfo.Account.Deposit(depositAmount);
					UpdateBalance(selectedAccountInfo.Account);
					LogTransaction(null, selectedAccountInfo.Account.AccountNumber, depositAmount, TransactionType.Deposit);
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


		private void comboBox_Accounts_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}

	public class AccountInfo
	{
		public Account Account { get; set; }
		public string DisplayText { get; set; }

		public override string ToString()
		{
			return DisplayText;
		}
	}
}
