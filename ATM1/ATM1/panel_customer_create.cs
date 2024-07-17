using ATM_App;
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
	public partial class panel_customer_create : UserControl
	{
		private string ConnectionString = UserContext.ConnectionStringWithDB;

		public panel_customer_create()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Retrieve user inputs from text boxes
			string firstName = textBox1.Text;
			string lastName = textBox2.Text;
			string phoneNumber = textBox3.Text;
			string email = textBox4.Text;
			string pin = textBox5.Text;

			// Validate inputs (add your validation logic here)

			// Create a Customer object
			Customer newCustomer = new Customer
			{
				FirstName = firstName,
				LastName = lastName,
				Phone = phoneNumber,
				Email = email,
				PIN = pin
			};

			Console.WriteLine( newCustomer.GetCustomerDetails());
			// Optionally, save the new customer to a database
			SaveCustomerToDatabase(newCustomer);

			// Clear input fields or provide feedback to the user
			ClearInputFields();
		}

		private void SaveCustomerToDatabase(Customer customer)
		{
			string customerDetails = customer.SaveToDatabase(ConnectionString);
			if (customerDetails != null)
			{
				MessageBox.Show(customerDetails, "Customer Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void ClearInputFields()
		{
			// Clear all input fields after creating a customer
			textBox1.Text = string.Empty; // First Name
			textBox2.Text = string.Empty; // Last Name
			textBox3.Text = string.Empty; // Phone Number
			textBox4.Text = string.Empty; // Email
			textBox5.Text = string.Empty; // PIN
		}
	}

}
