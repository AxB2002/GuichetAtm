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
	public partial class adminControl : UserControl
	{
		MainMenu mainMenu;
		public adminControl()
		{
			InitializeComponent();
		}

		private void btn_pay_interest_Click(object sender, EventArgs e)
		{
			ApplyInterestToSavingsAccounts();
			AddCustomControlToPanel<panel_pay_Interest>("panel1");
		}

		private void ApplyInterestToSavingsAccounts()
		{
			string connectionString = UserContext.ConnectionStringWithDB;
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				// Query to update all savings accounts with 1% interest
				string query = @"
            UPDATE Accounts
            SET Balance = Balance * 1.01
            WHERE AccountType = 1"; // Assuming AccountType 1 is for savings accounts

				MySqlCommand cmd = new MySqlCommand(query, connection);
				connection.Open();
				int rowsAffected = cmd.ExecuteNonQuery();

				MessageBox.Show($"{rowsAffected} savings accounts updated with 1% interest.");
			}
		}

		private void btn_customer_create_Click(object sender, EventArgs e)
		{
			AddCustomControlToPanel<panel_customer_create>("panel1");
		}

		private void btn_create_Account_Click(object sender, EventArgs e)
		{
			AddCustomControlToPanel<panel_Account_create>("panel1");
		}

		private void btn_manage_access_Click(object sender, EventArgs e)
		{
			AddCustomControlToPanel<panel_Manage_Acccess>("panel1");
		}

		private void btn_view_transaction_Click(object sender, EventArgs e)
		{
			AddCustomControlToPanel<panel_View_Transactions>("panel1");
		}

		private void btn_add_money_Click(object sender, EventArgs e)
		{
			AddCustomControlToPanel<panel_add_to_atm>("panel1");
		}

		private void btn_increase_loc_Click(object sender, EventArgs e)
		{

			IncreaseBalanceForLinesOfCredit();
			AddCustomControlToPanel<Panel_Increase_loc>("panel1");

		}
		private void IncreaseBalanceForLinesOfCredit()
		{
			string connectionString = UserContext.ConnectionStringWithDB;
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				// Query to update all lines of credit accounts with 5% increase
				string query = @"
            UPDATE Accounts
            SET Balance = Balance * 1.05
            WHERE AccountType = 4"; // Assuming AccountType 4 is for lines of credit

				MySqlCommand cmd = new MySqlCommand(query, connection);
				connection.Open();
				int rowsAffected = cmd.ExecuteNonQuery();

				MessageBox.Show($"{rowsAffected} line of credit accounts updated with 5% increase.");
			}
		}

		private void btn_withdraw_money_Click(object sender, EventArgs e)
		{

			AddCustomControlToPanel<panel_WithdrawMoney>("panel1");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void AddCustomControlToPanel<T>(string panelName) where T : Control, new()
		{

			MainMenu mainForm = this.ParentForm as MainMenu;

			if (mainForm != null)
			{

				// Find the panel by name
				Panel targetPanel = mainForm.Controls.Find(panelName, true).FirstOrDefault() as Panel;

				if (targetPanel != null)
				{
					// Clear existing controls in the panel
					targetPanel.Controls.Clear();

					// Create an instance of the custom user control
					T customControl = new T();

					// Set the dock style to fill the panel
					customControl.Dock = DockStyle.Fill;

					// Add the custom control to the panel
					targetPanel.Controls.Add(customControl);

					// Make the panel visible
					targetPanel.Visible = true;
				}
				else
				{
					Console.WriteLine($"Panel {panelName} not found.");
				}
			}
		}


	}
}
