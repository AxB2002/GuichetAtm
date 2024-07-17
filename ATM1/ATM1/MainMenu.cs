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
	public partial class MainMenu : Form
	{
		public MainMenu(string val)
		{
			InitializeComponent();
			if (val == "admin")
			{
				AddCustomControlToPanel<adminControl>("panel2");

			}
			else if (val == "user")
			{
				AddCustomControlToPanel<UserOptions>("panel2");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			AddCustomControlToPanel<panel_pay_Interest>("panel1");
		}
		private void btn_customer_create_click(object sender, EventArgs e)
		{
			AddCustomControlToPanel<panel_customer_create>("panel1");
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

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

			AddCustomControlToPanel<Panel_Increase_loc>("panel1");
		}

		private void btn_withdraw_money_Click(object sender, EventArgs e)
		{

			AddCustomControlToPanel<panel_WithdrawMoney>("panel1");
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		public void AddCustomControlToPanel<T>(string panelName) where T : Control, new()
		{
			// Find the panel by name
			Panel targetPanel = this.Controls.Find(panelName, true).FirstOrDefault() as Panel;

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
