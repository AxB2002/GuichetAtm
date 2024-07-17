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
	public partial class panel_Account_create : UserControl
	{
		public panel_Account_create()
		{
			InitializeComponent();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			string selectedAccountType = comboBox3.SelectedItem?.ToString();
			string customerID = textBox1.Text.Trim();
			string connectionString = UserContext.ConnectionStringWithDB;

			// Validate inputs
			if (string.IsNullOrEmpty(selectedAccountType))
			{
				MessageBox.Show("Please select an account type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(customerID))
			{
				MessageBox.Show("Please enter a customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Retrieve customer based on customerID (assuming you have a method to fetch customer details)
			Customer customer = RetrieveCustomerFromDatabase(connectionString, customerID);

			if (customer == null)
			{
				MessageBox.Show($"Customer with ID {customerID} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			bool hasCheckingAccount = customer.Accounts.Any(a => a is CheckingAccount);

			// If trying to create an account other than Checking Account and no Checking Account exists
			if (!hasCheckingAccount && selectedAccountType != "Checking Account")
			{
				MessageBox.Show("Customer must have at least one checking account before creating a new account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			bool hasLineOfCreditAccount = customer.Accounts.Any(a => a is LineOfCreditAccount);

			// Create the account based on selected account type
			Account newAccount;
			switch (selectedAccountType)
			{
				case "Mortgage Account":
					newAccount = new MortgageAccount();  // Instantiate CheckingAccount
					break;
				case "Checking Account":
					newAccount = new CheckingAccount(); // Instantiate SavingsAccount 
					break;
				case "Saving Account":
					newAccount = new SavingsAccount();// Instantiate MortgageAccount
					break;
				case "Line Of Credit Account":
					if (hasLineOfCreditAccount)
					{
						MessageBox.Show("Customer can have only one Line Of Credit Account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					newAccount = new LineOfCreditAccount(); // Instantiate LineOfCreditAccount
					break;
				default:
					MessageBox.Show("Unknown account type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
			}

			// Add the new account to the customer's list of accounts
			customer.Accounts.Add(newAccount);
			customer.SaveAccountToDB(connectionString, newAccount);

			// Save the updated customer information (including accounts) to the database


			MessageBox.Show($"New {selectedAccountType} created successfully for customer {customer.FirstName} {customer.LastName}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		// Example method to retrieve customer details from database based on customerID
		public static Customer RetrieveCustomerFromDatabase(string connectionString, string customerCode)
		{
			Customer customer = null;

			using (MySqlConnection conn = new MySqlConnection(connectionString))
			{
				string query = "SELECT * FROM Clients WHERE ClientID = @CustomerCode";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@CustomerCode", customerCode);

				try
				{
					conn.Open();
					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							customer = new Customer
							{
								CustomerCode = reader["ClientID"].ToString(),
								FirstName = reader["FirstName"].ToString(),
								LastName = reader["LastName"].ToString(),
								Phone = reader["Phone"].ToString(),
								Email = reader["Email"].ToString(),
								PIN = reader["PIN"].ToString(),
								Accounts = new List<Account>()
							};

							// Load customer's accounts
							customer.LoadAccounts(connectionString);
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error retrieving customer: {ex.Message}");
				}
				finally
				{
					conn.Close();
				}
			}

			return customer;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
