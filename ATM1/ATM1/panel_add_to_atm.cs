using ATM_App;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ATM1
{
	public partial class panel_add_to_atm : UserControl
	{
		private decimal currentAmount;

		public panel_add_to_atm()
		{
			InitializeComponent();
			LoadCurrentAmount();
		}

		private void LoadCurrentAmount()
		{
			string connectionString = UserContext.ConnectionStringWithDB;
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				string query = "SELECT CashAmount FROM ATM WHERE ID = 1";

				try
				{
					connection.Open();
					MySqlCommand cmd = new MySqlCommand(query, connection);
					var result = cmd.ExecuteScalar();

					if (result != null && result != DBNull.Value)
					{
						currentAmount = Convert.ToDecimal(result);
						lblAmount.Text = currentAmount.ToString("C");
					}
					else
					{
						// If no rows returned, insert a default value
						InsertDefaultATMAmount();
						currentAmount = 0; // Set to 0 or another default value as needed
						lblAmount.Text = currentAmount.ToString("C");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error loading current ATM amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void InsertDefaultATMAmount()
		{
			string connectionString = UserContext.ConnectionStringWithDB;
			string insertQuery = "INSERT INTO ATM (ID, CashAmount) VALUES (1, 0)";

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connectionString))
				{
					MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
					connection.Open();
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error inserting default ATM amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btn_Add_Click(object sender, EventArgs e)
		{
			if (decimal.TryParse(textBox_Amount.Text, out decimal amountToAdd))
			{
				if (currentAmount + amountToAdd <= 20000)
				{
					currentAmount += amountToAdd;
					UpdateATMAmount(currentAmount);
					//lblAmount.Text = currentAmount.ToString("C");
					MessageBox.Show("Amount added successfully!");
				}
				else
				{
					MessageBox.Show("Cannot add amount. The total amount exceeds the limit of $20,000.");
				}
			}
			else
			{
				MessageBox.Show("Please enter a valid amount.");
			}
		}

		private void UpdateATMAmount(decimal newAmount)
		{
			string connectionString = UserContext.ConnectionStringWithDB;
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				string query = "UPDATE ATM SET CashAmount = @amount WHERE ID = 1";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@amount", newAmount);
				connection.Open();
				cmd.ExecuteNonQuery();
				connection.Close();
			}
		}
	}
}
