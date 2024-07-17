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
	public partial class panel_View_Transactions : UserControl
	{
		public panel_View_Transactions()
		{
			InitializeComponent();
			LoadTransactionData();
		}

		private void LoadTransactionData()
		{
			string connectionString = UserContext.ConnectionStringWithDB;

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				string query = "SELECT * FROM Transactions";

				using (MySqlCommand cmd = new MySqlCommand(query, connection))
				{
					MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);
					dataGridView1.DataSource = dataTable;
				}
			}
		}
	}
}