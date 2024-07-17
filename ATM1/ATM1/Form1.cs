using ATM_App;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ATM1
{
	public partial class Form1 : Form
	{
		private int loginAttempts = 0;
		private const int MaxLoginAttempts = 3;
		private string ConnectionString = UserContext.ConnectionStringWithDB;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtCustomerCode.Text.Trim(), out int customerCode))
			{
				MessageBox.Show("Invalid customer code. Please enter a valid numeric customer code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string pin = txtPIN.Text.Trim();

			if (AuthenticateAdmin(customerCode, pin))
			{
				// Navigate to Main Menu as admin
				MainMenu mainMenu = new MainMenu("admin");
				mainMenu.Show();
				this.Hide();
			}
			else if (AuthenticateCustomer(customerCode, pin))
			{
				// Navigate to Main Menu as regular customer
				MainMenu mainMenu = new MainMenu("user");
				mainMenu.Show();
				this.Hide();
			}
			else
			{
				loginAttempts++;

				if (loginAttempts >= MaxLoginAttempts || CheckIfCustomerBlocked(customerCode, pin))
				{
					BlockCustomerAccess(customerCode);
					MessageBox.Show("Account blocked. Please contact the bank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					MessageBox.Show("Invalid customer code or PIN. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private bool AuthenticateCustomer(int customerCode, string pin)
		{
			// Use the Customer class to authenticate
			Customer customer = Customer.AuthenticateCustomer(ConnectionString, customerCode, pin);
			if (customer == null || customer.Acess == "block")
			{
				return false;
			}
			return true;
		}

		private bool CheckIfCustomerBlocked(int customerCode, string pin)
		{
			// Use the Customer class to authenticate
			Customer customer = Customer.AuthenticateCustomer(ConnectionString, customerCode, pin);
			if(customer==null)
			{
				return false;
			}
			if ( customer.Acess == "block")
			{
				return true;
			}
			return false;
		}

		private bool AuthenticateAdmin(int customerCode, string pin)
		{
			// Assuming admin's ClientID is 0
			if (customerCode == 0 && pin == "admin")
			{
				return true;
			}
			return false;
		}

		private void BlockCustomerAccess(int customerCode)
		{
			using (MySqlConnection connection = new MySqlConnection(ConnectionString))
			{
				connection.Open();
				using (MySqlCommand cmd = new MySqlCommand("UPDATE Clients SET Acess = 'block' WHERE ClientID = @CustomerCode", connection))
				{
					cmd.Parameters.AddWithValue("@CustomerCode", customerCode);
					cmd.ExecuteNonQuery();
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtCustomerCode.Clear();
			txtPIN.Clear();
		}

		private void label3_Click(object sender, EventArgs e)
		{
		}
	}
}
