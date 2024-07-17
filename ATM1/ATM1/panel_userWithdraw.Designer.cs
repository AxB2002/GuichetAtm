namespace ATM1
{
	partial class panel_userWithdraw
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel3 = new Panel();
			tableLayoutPanel3 = new TableLayoutPanel();
			panel4 = new Panel();
			textBox_withdrawmoney = new TextBox();
			label2 = new Label();
			comboBox_Accounts = new ComboBox();
			button9 = new Button();
			panel3.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			panel4.SuspendLayout();
			SuspendLayout();
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb(46, 125, 50);
			panel3.Controls.Add(tableLayoutPanel3);
			panel3.Dock = DockStyle.Fill;
			panel3.ImeMode = ImeMode.NoControl;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(462, 559);
			panel3.TabIndex = 8;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 2;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(panel4, 1, 2);
			tableLayoutPanel3.Controls.Add(label2, 0, 1);
			tableLayoutPanel3.Controls.Add(comboBox_Accounts, 0, 2);
			tableLayoutPanel3.Controls.Add(button9, 0, 3);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(0, 0);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 7;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.41495F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7659788F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882519F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882519F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882519F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7542143F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.4173012F));
			tableLayoutPanel3.Size = new Size(462, 559);
			tableLayoutPanel3.TabIndex = 9;
			// 
			// panel4
			// 
			panel4.BackColor = Color.White;
			panel4.Controls.Add(textBox_withdrawmoney);
			panel4.Dock = DockStyle.Fill;
			panel4.Location = new Point(234, 232);
			panel4.Name = "panel4";
			panel4.Size = new Size(225, 26);
			panel4.TabIndex = 11;
			// 
			// textBox_withdrawmoney
			// 
			textBox_withdrawmoney.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox_withdrawmoney.BorderStyle = BorderStyle.None;
			textBox_withdrawmoney.Location = new Point(7, 10);
			textBox_withdrawmoney.Name = "textBox_withdrawmoney";
			textBox_withdrawmoney.PlaceholderText = "Withdraw Amount";
			textBox_withdrawmoney.Size = new Size(431, 18);
			textBox_withdrawmoney.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Bottom;
			label2.Font = new Font("Trebuchet MS", 23.7735844F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(3, 164);
			label2.Name = "label2";
			label2.Padding = new Padding(10, 10, 10, 20);
			label2.Size = new Size(225, 65);
			label2.TabIndex = 0;
			label2.Text = "WithDraw";
			// 
			// comboBox_Accounts
			// 
			comboBox_Accounts.AllowDrop = true;
			comboBox_Accounts.Dock = DockStyle.Fill;
			comboBox_Accounts.FormattingEnabled = true;
			comboBox_Accounts.Items.AddRange(new object[] { "Mortgage Account", "Checking Account", "Saving Account", "Line Of Credit Account" });
			comboBox_Accounts.Location = new Point(3, 232);
			comboBox_Accounts.Name = "comboBox_Accounts";
			comboBox_Accounts.Size = new Size(225, 25);
			comboBox_Accounts.TabIndex = 10;
			// 
			// button9
			// 
			button9.Dock = DockStyle.Fill;
			button9.Font = new Font("Segoe UI Semibold", 10.8679247F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button9.Location = new Point(3, 264);
			button9.Name = "button9";
			button9.Size = new Size(225, 26);
			button9.TabIndex = 8;
			button9.Text = "Withdraw";
			button9.UseVisualStyleBackColor = true;
			button9.Click += button9_Click;
			// 
			// panel_userWithdraw
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel3);
			Name = "panel_userWithdraw";
			Size = new Size(462, 559);
			panel3.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel3;
		private TableLayoutPanel tableLayoutPanel3;
		private Panel panel4;
		private TextBox textBox_withdrawmoney;
		private Label label2;
		private ComboBox comboBox_Accounts;
		private Button button9;
	}
}
