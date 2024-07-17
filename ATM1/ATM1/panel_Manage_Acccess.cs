using ATM_App;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ATM1
{
	public partial class panel_Manage_Acccess : UserControl
	{
		public panel_Manage_Acccess()
		{
			InitializeComponent();

			// Wire up event handlers
			button10.Click += ButtonSearch_Click;
			btn_update_access.Click += BtnUpdateAccess_Click;

			// Initialize UI
			InitializeUI();
		}

		private void InitializeUI()
		{
			// Clear existing UI elements
			textBox_client_id.Text = string.Empty;
			label5.Text = "Customer Name:";
			label6.Text = "Name"; // Example label text
			label8.Text = "Current Status:";
			label7.Text = "Status"; // Example label text

			// Set initial UI state
			comboBox2.SelectedIndex = -1;
		}

		private void ButtonSearch_Click(object sender, EventArgs e)
		{
			// Retrieve customer details based on entered ID
			string clientId = textBox_client_id.Text.Trim();
			if (!string.IsNullOrEmpty(clientId))
			{
				// Query database to fetch customer details
				string query = "SELECT FirstName, Acess FROM Clients WHERE ClientID = @ClientID";

				using (MySqlConnection connection = new MySqlConnection(UserContext.ConnectionStringWithDB))
				{
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@ClientID", clientId);

					try
					{
						connection.Open();
						using (MySqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								string name = reader.GetString("FirstName");
								string status = reader.GetString("Acess");

								// Update UI with retrieved details
								label6.Text = name;
								label7.Text = status;
							}
							else
							{
								MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								InitializeUI();
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Error retrieving customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Please enter a valid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnUpdateAccess_Click(object sender, EventArgs e)
		{
			string clientId = textBox_client_id.Text.Trim();
			string newStatus = comboBox2.SelectedItem?.ToString();

			if (!string.IsNullOrEmpty(clientId) && !string.IsNullOrEmpty(newStatus))
			{
				// Update customer access status in the database
				string query = "UPDATE Clients SET Acess = @Status WHERE ClientID = @ClientID";

				using (MySqlConnection connection = new MySqlConnection(UserContext.ConnectionStringWithDB))
				{
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@Status", newStatus);
					cmd.Parameters.AddWithValue("@ClientID", clientId);

					try
					{
						connection.Open();
						int rowsAffected = cmd.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							MessageBox.Show("Access status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							// Update UI with new status
							label7.Text = newStatus;
						}
						else
						{
							MessageBox.Show("Failed to update access status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Error updating access status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Please select a status and enter a valid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
