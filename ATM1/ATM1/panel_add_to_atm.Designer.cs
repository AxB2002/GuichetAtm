namespace ATM1
{
	partial class panel_add_to_atm
	{
		private System.ComponentModel.IContainer components = null;
		private TableLayoutPanel tableLayoutPanel7;
		private TableLayoutPanel tableLayoutPanel8;
		private Label label9;
		private Panel panel13;
		private Button btn_Add;
		private Panel panel14;
		private TextBox textBox_Amount;
		private Panel panel15;
		private Label lblAmount;
		private Label label13;
		private Panel panel2;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			tableLayoutPanel7 = new TableLayoutPanel();
			tableLayoutPanel8 = new TableLayoutPanel();
			label9 = new Label();
			panel13 = new Panel();
			btn_Add = new Button();
			panel14 = new Panel();
			textBox_Amount = new TextBox();
			panel15 = new Panel();
			lblAmount = new Label();
			label13 = new Label();
			panel2 = new Panel();
			tableLayoutPanel7.SuspendLayout();
			tableLayoutPanel8.SuspendLayout();
			panel13.SuspendLayout();
			panel14.SuspendLayout();
			panel15.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();

			// tableLayoutPanel7
			tableLayoutPanel7.ColumnCount = 1;
			tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 1);
			tableLayoutPanel7.Dock = DockStyle.Fill;
			tableLayoutPanel7.Location = new Point(0, 0);
			tableLayoutPanel7.Name = "tableLayoutPanel7";
			tableLayoutPanel7.RowCount = 3;
			tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 81.8181839F));
			tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel7.Size = new Size(539, 551);
			tableLayoutPanel7.TabIndex = 9;

			// tableLayoutPanel8
			tableLayoutPanel8.ColumnCount = 1;
			tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel8.Controls.Add(label9, 0, 1);
			tableLayoutPanel8.Controls.Add(panel13, 0, 3);
			tableLayoutPanel8.Controls.Add(panel15, 0, 2);
			tableLayoutPanel8.Dock = DockStyle.Fill;
			tableLayoutPanel8.Location = new Point(3, 53);
			tableLayoutPanel8.Name = "tableLayoutPanel8";
			tableLayoutPanel8.RowCount = 7;
			tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6721363F));
			tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6721325F));
			tableLayoutPanel8.Size = new Size(533, 444);
			tableLayoutPanel8.TabIndex = 2;

			// label9
			label9.AutoSize = true;
			label9.Dock = DockStyle.Top;
			label9.Font = new Font("Trebuchet MS", 23.7735844F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label9.ForeColor = Color.White;
			label9.Location = new Point(3, 87);
			label9.Name = "label9";
			label9.Padding = new Padding(10, 10, 10, 20);
			label9.Size = new Size(527, 53);
			label9.TabIndex = 1;
			label9.Text = "Add Money to ATM";

			// panel13
			panel13.Controls.Add(btn_Add);
			panel13.Controls.Add(panel14);
			panel13.Dock = DockStyle.Fill;
			panel13.Location = new Point(3, 196);
			panel13.Name = "panel13";
			panel13.Size = new Size(527, 47);
			panel13.TabIndex = 3;

			// btn_Add
			btn_Add.Anchor = AnchorStyles.None;
			btn_Add.Location = new Point(207, 8);
			btn_Add.Name = "btn_Add";
			btn_Add.Size = new Size(105, 30);
			btn_Add.TabIndex = 3;
			btn_Add.Text = "Add Money";
			btn_Add.UseVisualStyleBackColor = true;
			btn_Add.Click += btn_Add_Click;

			// panel14
			panel14.Anchor = AnchorStyles.Left;
			panel14.BackColor = Color.White;
			panel14.Controls.Add(textBox_Amount);
			panel14.Location = new Point(3, 0);
			panel14.Name = "panel14";
			panel14.Size = new Size(200, 40);
			panel14.TabIndex = 4;

			// textBox_Amount
			textBox_Amount.BorderStyle = BorderStyle.None;
			textBox_Amount.Location = new Point(3, 10);
			textBox_Amount.Name = "textBox_Amount";
			textBox_Amount.PlaceholderText = "Enter amount";
			textBox_Amount.Size = new Size(180, 18);
			textBox_Amount.TabIndex = 2;

			// panel15
			panel15.Anchor = AnchorStyles.Left;
			panel15.BackColor = Color.FromArgb(46, 125, 50);
			panel15.Controls.Add(lblAmount);
			panel15.Controls.Add(label13);
			panel15.Location = new Point(3, 146);
			panel15.Name = "panel15";
			panel15.Size = new Size(295, 41);
			panel15.TabIndex = 5;

			// lblAmount
			lblAmount.AutoSize = true;
			lblAmount.ForeColor = Color.White;
			lblAmount.Location = new Point(147, 10);
			lblAmount.Name = "lblAmount";
			lblAmount.Size = new Size(50, 17);
			lblAmount.TabIndex = 1;
			lblAmount.Text = "0.00$";

			// label13
			label13.AutoSize = true;
			label13.ForeColor = Color.White;
			label13.Location = new Point(24, 10);
			label13.Name = "label13";
			label13.Size = new Size(119, 17);
			label13.TabIndex = 0;
			label13.Text = "Current Amount:";

			// panel2
			panel2.BackColor = Color.FromArgb(46, 125, 50);
			panel2.Controls.Add(tableLayoutPanel7);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(539, 551);
			panel2.TabIndex = 9;

			// panel_add_to_atm
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel2);
			Name = "panel_add_to_atm";
			Size = new Size(539, 551);
			tableLayoutPanel7.ResumeLayout(false);
			tableLayoutPanel8.ResumeLayout(false);
			tableLayoutPanel8.PerformLayout();
			panel13.ResumeLayout(false);
			panel14.ResumeLayout(false);
			panel14.PerformLayout();
			panel15.ResumeLayout(false);
			panel15.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}
	}
}
