using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PIN { get; set; }
		public string Acess { get; set; }

		public List<Account> Accounts { get; set; }

		public Customer()
		{
			Accounts = new List<Account>();
		}

		public string GetCustomerDetails()
        {
            return $"Customer Code: {CustomerCode}, Name: {FirstName} {LastName}, Phone: {Phone}, Email: {Email}";
        }

		public static Customer AuthenticateCustomer(string connectionString, int customerCode, string pin)
		{
			using (MySqlConnection conn = new MySqlConnection(connectionString))
			{
				string query = "SELECT * FROM Clients WHERE ClientID = @CustomerCode AND PIN = @PIN";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@CustomerCode", customerCode);
				cmd.Parameters.AddWithValue("@PIN", pin);

				conn.Open();
				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						Customer customer = new Customer
						{
							CustomerCode = reader["ClientID"].ToString(),
							FirstName = reader["FirstName"].ToString(),
							LastName = reader["LastName"].ToString(),
							Phone = reader["Phone"].ToString(),
							Email = reader["Email"].ToString(),
							PIN = reader["PIN"].ToString(),
							Acess = reader["Acess"].ToString()
						};
						UserContext.CustomerID = customer.CustomerCode;
						return customer;
					}
				}
				conn.Close();
			}
			return null;
		}

		public void LoadAccounts(string connectionString)
		{
			using (MySqlConnection conn = new MySqlConnection(connectionString))
			{
				string query = "SELECT * FROM Accounts WHERE ClientID = @CustomerCode";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@CustomerCode", CustomerCode);

				conn.Open();
				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						string accountType = reader["AccountType"].ToString();
						Account account = accountType switch
						{
							"1" => new CheckingAccount(),
							"2" => new SavingsAccount(),
							"3" => new MortgageAccount(),
							"4" => new LineOfCreditAccount(),
							_ => throw new InvalidOperationException("Unknown account type")
						};
						account.AccountNumber = reader["AccountNumber"].ToString();
						account.Balance = Convert.ToDecimal(reader["Balance"]);
						Accounts.Add(account);
					}
				}
				conn.Close();
			}
		}

	
		public decimal GetBalance(string accountNumber)
		{
			Account account = Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
			return account != null ? account.Balance : 0;
		}

		/*	public List<Transaction> GetTransactionHistory(string connectionString, string accountNumber)
			{
				List<Transaction> transactions = new List<Transaction>();

				using (MySqlConnection conn = new MySqlConnection(connectionString))
				{
					string query = "SELECT * FROM Transactions WHERE AccountNumber = @AccountNumber";
					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);

					conn.Open();
					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							Transaction transaction = new Transaction(
								reader["TransactionId"].ToString(),
								reader["CustomerCode"].ToString(),
								reader["AccountNumber"].ToString(),
								reader["TransactionType"].ToString(),
								Convert.ToDecimal(reader["Amount"]),
								Convert.ToDateTime(reader["Date"])
							);
							transactions.Add(transaction);
						}
					}
					conn.Close();
				}
				return transactions;
			}*/

		public string SaveToDatabase(string connectionString)
		{
			string customerDetails = null;
			using (MySqlConnection conn = new MySqlConnection(connectionString))
			{
				string query = @"INSERT INTO Clients ( FirstName, LastName, Phone, Email, PIN, Acess)
                                 VALUES (@FirstName, @LastName, @Phone, @Email, @PIN, @Acess)";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@FirstName", FirstName);
				cmd.Parameters.AddWithValue("@LastName", LastName);
				cmd.Parameters.AddWithValue("@Phone", Phone);
				cmd.Parameters.AddWithValue("@Email", Email);
				cmd.Parameters.AddWithValue("@PIN", PIN);
				cmd.Parameters.AddWithValue("@Acess", "unbloack");
				string retrieveQuery = @"SELECT * FROM Clients WHERE FirstName=@FirstName AND LastName=@LastName AND PIN=@PIN";
				MySqlCommand cmdRetrieve = new MySqlCommand(retrieveQuery, conn);
				cmdRetrieve.Parameters.AddWithValue("@FirstName", FirstName);
				cmdRetrieve.Parameters.AddWithValue("@LastName", LastName);
				cmdRetrieve.Parameters.AddWithValue("@PIN", PIN);
				try
				{
					conn.Open();
					int rowsAffected = cmd.ExecuteNonQuery();
					if (rowsAffected > 0)
					{
						using (MySqlDataReader reader = cmdRetrieve.ExecuteReader())
						{
							if (reader.Read())
							{
								customerDetails = $"Customer Code: {reader["ClientID"]}\n" +
														  $"Name: {reader["FirstName"]} {reader["LastName"]}\n" +
														  $"Phone: {reader["Phone"]}\n" +
														  $"Email: {reader["Email"]}\n" +
														  $"PIN: {reader["PIN"]}\n" +
														  $"Acess: {reader["Acess"]}";
							}
						}
					}
					else
					{
						Console.WriteLine("Failed to save customer to database.");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error: {ex.Message}");
				}
				finally
				{
					conn.Close();
				}
			}
			return customerDetails;
		}
		public void SaveAccountToDB(string connectionString, Account account)
		{
			using (MySqlConnection conn = new MySqlConnection(connectionString))
			{
				string query = @"INSERT INTO Accounts (ClientID, AccountType, Balance)
                         VALUES (@ClientID, @AccountType, @Balance)";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				Console.WriteLine(GetAccountTypeID(account));
				cmd.Parameters.AddWithValue("@ClientID", CustomerCode); // Assuming CustomerCode maps to ClientID
				cmd.Parameters.AddWithValue("@AccountType", GetAccountTypeID(account)); // GetAccountTypeID needs to be implemented
				cmd.Parameters.AddWithValue("@Balance", account.Balance);

				try
				{
					conn.Open();
					int rowsAffected = cmd.ExecuteNonQuery();
					if (rowsAffected > 0)
					{
						// Retrieve the generated AccountNumber if needed
						account.AccountNumber = cmd.LastInsertedId.ToString(); // Assuming AccountNumber is AUTO_INCREMENT
						Accounts.Add(account); // Add the account to the local list
					}
					else
					{
						Console.WriteLine("Failed to save account to database.");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error: {ex.Message}");
				}
				finally
				{
					conn.Close();
				}
			}
		}
		public int GetAccountTypeID(Account account)
		{
			if (account is CheckingAccount)
			{
				return 1; // Assuming 1 is the TypeID for Checking Account
			}
			else if (account is SavingsAccount)
			{
				return 2; // Assuming 2 is the TypeID for Savings Account
			}
			else if (account is MortgageAccount)
			{
				return 3; // Assuming 3 is the TypeID for Mortgage Account
			}
			else if (account is LineOfCreditAccount)
			{
				return 4; // Assuming 4 is the TypeID for Line of Credit Account
			}
			else
			{
				throw new InvalidOperationException("Unknown account type");
			}
		}


	}
}