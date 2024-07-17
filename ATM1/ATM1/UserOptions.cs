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
	public partial class UserOptions : UserControl
	{
		public UserOptions()
		{
			InitializeComponent();
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

		private void btn_Deposit_Click(object sender, EventArgs e)
		{
			AddCustomControlToPanel<panel_deposit>("panel1");
		}

		private void btn_WithDraw_Click(object sender, EventArgs e)
		{
			AddCustomControlToPanel<panel_userWithdraw>("panel1");
		}

		private void btn_Transfer_Click(object sender, EventArgs e)
		{
			AddCustomControlToPanel<panel_Transfer>("panel1");
		}

		private void btn_Bill_Payment_Click(object sender, EventArgs e)
		{
			AddCustomControlToPanel<panel_bill_payment>("panel1");
		}

		private void btn_ShowBalance_Click(object sender, EventArgs e)
		{
			AddCustomControlToPanel<panel_show_balance>("panel1");
		}
	}


}
