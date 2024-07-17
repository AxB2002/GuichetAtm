using ATM_App;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
	public partial class panel_show_balance : UserControl
	{
		public panel_show_balance()
		{
			InitializeComponent();
			LoadTransactionData();
		}

		private void LoadTransactionData()
		{
			string connectionString = UserContext.ConnectionStringWithDB;

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				string query = @"SELECT A.AccountNumber, T.Label AS AccountType, A.Balance
                         FROM Accounts A
                         INNER JOIN AccountType T ON A.AccountType = T.TypeID
                         WHERE A.ClientID = @ClientID";

				using (MySqlCommand cmd = new MySqlCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@ClientID", UserContext.CustomerID);

					MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);

					// Bind the data to the DataGridView
					dataGridView1.DataSource = dataTable;

					/*// Optionally, you can hide specific columns if needed
					dataGridView1.Columns["ClientID"].Visible = false; // Hide ClientID column
					dataGridView1.Columns["AccountType"].HeaderText = "Account Type"; // Rename AccountType column header*/
				}
			}
		}

	}
}
