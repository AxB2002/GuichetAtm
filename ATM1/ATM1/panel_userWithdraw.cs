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
	public partial class panel_userWithdraw : UserControl
	{
		public panel_userWithdraw()
		{
			InitializeComponent();
			LoadAccounts();
		}

		private void LoadAccounts()
		{
			string connectionString = UserContext.ConnectionStringWithDB;
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				string query = "SELECT AccountNumber, AccountType, Balance FROM Accounts WHERE ClientID = @ClientID AND AccountType!=4 AND AccountType!=3";
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
				// Get the selected account
				Account selectedAccount = selectedAccountInfo.Account;

				// Validate the withdrawal amount
				if (decimal.TryParse(textBox_withdrawmoney.Text, out decimal withdrawalAmount))
				{
					// Check if the withdrawal amount is valid
					if (withdrawalAmount <= 0)
					{
						MessageBox.Show("Please enter a valid withdrawal amount greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if (withdrawalAmount % 10 != 0)
					{
						MessageBox.Show("Please enter a withdrawal amount that is a multiple of $10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if (withdrawalAmount > 1000)
					{
						MessageBox.Show("Withdrawal amount cannot exceed $1000 per transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if (!IsATMCashAvailable(withdrawalAmount))
					{
						MessageBox.Show("ATM does not have enough cash to process this withdrawal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					// Check if the balance is sufficient for regular accounts
					if (selectedAccount.Balance >= withdrawalAmount)
					{
						
							selectedAccount.Withdraw(withdrawalAmount);
						  DeductCashFromATM(withdrawalAmount);
						  LogTransaction(selectedAccount.AccountNumber, null, withdrawalAmount, TransactionType.Withdrawal);
							UpdateBalance(selectedAccount);
					}
					else
					{
						string connectionString = UserContext.ConnectionStringWithDB;
						string query = "SELECT AccountNumber, Balance FROM Accounts WHERE ClientID = @ClientID AND AccountType = 4";

						// Replace with the actual client ID value you want to query for
						string yourClientIdValue = UserContext.CustomerID; // Replace with your actual client ID value

						using (MySqlConnection connection = new MySqlConnection(connectionString))
						{
							MySqlCommand cmd = new MySqlCommand(query, connection);
							cmd.Parameters.AddWithValue("@ClientID", yourClientIdValue);

							try
							{
								connection.Open();
								MySqlDataReader reader = cmd.ExecuteReader();

								// Assuming you only expect one Line of Credit account per client, use if instead of while
								if (reader.Read())
								{
									int accountNumber = reader.GetInt32("AccountNumber");
									decimal balance = reader.GetDecimal("Balance");

									// Instantiate a LineOfCreditAccount object with the retrieved data
									LineOfCreditAccount locAccount = new LineOfCreditAccount
									{
										AccountNumber = accountNumber.ToString(),
										Balance = balance
									};
									decimal remainingAmount = withdrawalAmount - selectedAccount.Balance;
									if(selectedAccount.Balance>0)
									 selectedAccount.Withdraw(selectedAccount.Balance); // Withdraw full available balance
									
									locAccount.Deposit(remainingAmount);
									MessageBox.Show("WithDrawn From Line Of Credit Account.");
									// Update balances
									UpdateBalance(selectedAccount);
									UpdateBalance(locAccount);
									DeductCashFromATM(withdrawalAmount);
									LogTransaction(selectedAccount.AccountNumber, null, withdrawalAmount, TransactionType.Withdrawal);

									// Now you can use locAccount as needed
									Console.WriteLine($"Line of Credit Account Number: {locAccount.AccountNumber}, Balance: {locAccount.Balance}");
								}
								else
								{
									Console.WriteLine("No Line of Credit account found for the specified client.");
								}

								reader.Close();
							}
							catch (Exception ex)
							{
								Console.WriteLine($"Error retrieving Line of Credit accounts: {ex.Message}");
							}
						}

						
						
					}
				}
				else
				{
					MessageBox.Show("Please enter a valid withdrawal amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Please select an account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private bool IsATMCashAvailable(decimal amountToWithdraw)
		{
			string connectionString = UserContext.ConnectionStringWithDB;
			string query = "SELECT CashAmount FROM ATM WHERE ID = 1";

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);

				try
				{
					connection.Open();
					object result = cmd.ExecuteScalar();
					if (result != null && result != DBNull.Value)
					{
						decimal atmBalance = Convert.ToDecimal(result);
						return atmBalance >= amountToWithdraw;
					}
					else
					{
						MessageBox.Show("Error retrieving ATM cash amount. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error checking ATM cash amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
		}

		private bool DeductCashFromATM(decimal amountToDeduct)
		{
			string connectionString = UserContext.ConnectionStringWithDB;
			string query = "UPDATE ATM SET CashAmount = CashAmount - @Amount WHERE ID = 1 AND CashAmount >= @Amount";

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@Amount", amountToDeduct);

				try
				{
					connection.Open();
					int rowsAffected = cmd.ExecuteNonQuery();
					return rowsAffected > 0; // Returns true if deduction was successful
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error deducting cash from ATM: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
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
						MessageBox.Show("WithDraw successful.");
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

	
}