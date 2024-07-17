namespace ATM1
{
	partial class panel_Transfer
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
			comboBox_toAcc = new ComboBox();
			panel4 = new Panel();
			textBox_Amount = new TextBox();
			label2 = new Label();
			comboBox_fromAcc = new ComboBox();
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
			panel3.Size = new Size(481, 549);
			panel3.TabIndex = 7;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 2;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(comboBox_toAcc, 1, 2);
			tableLayoutPanel3.Controls.Add(panel4, 0, 3);
			tableLayoutPanel3.Controls.Add(label2, 0, 1);
			tableLayoutPanel3.Controls.Add(comboBox_fromAcc, 0, 2);
			tableLayoutPanel3.Controls.Add(button9, 1, 3);
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
			tableLayoutPanel3.Size = new Size(481, 549);
			tableLayoutPanel3.TabIndex = 9;
			// 
			// comboBox_toAcc
			// 
			comboBox_toAcc.AllowDrop = true;
			comboBox_toAcc.Dock = DockStyle.Fill;
			comboBox_toAcc.FormattingEnabled = true;
			comboBox_toAcc.Items.AddRange(new object[] { "Mortgage Account", "Checking Account", "Saving Account", "Line Of Credit Account" });
			comboBox_toAcc.Location = new Point(243, 228);
			comboBox_toAcc.Name = "comboBox_toAcc";
			comboBox_toAcc.Size = new Size(235, 25);
			comboBox_toAcc.TabIndex = 12;
			comboBox_toAcc.Text = "To Account";
			// 
			// panel4
			// 
			panel4.BackColor = Color.White;
			panel4.Controls.Add(textBox_Amount);
			panel4.Dock = DockStyle.Fill;
			panel4.Location = new Point(3, 260);
			panel4.Name = "panel4";
			panel4.Size = new Size(234, 26);
			panel4.TabIndex = 11;
			// 
			// textBox_Amount
			// 
			textBox_Amount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox_Amount.BorderStyle = BorderStyle.None;
			textBox_Amount.Location = new Point(7, 10);
			textBox_Amount.Name = "textBox_Amount";
			textBox_Amount.PlaceholderText = "Transfer Amount";
			textBox_Amount.Size = new Size(430, 18);
			textBox_Amount.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Bottom;
			label2.Font = new Font("Trebuchet MS", 23.7735844F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(3, 161);
			label2.Name = "label2";
			label2.Padding = new Padding(10, 10, 10, 20);
			label2.Size = new Size(234, 64);
			label2.TabIndex = 0;
			label2.Text = "Transfer";
			// 
			// comboBox_fromAcc
			// 
			comboBox_fromAcc.AllowDrop = true;
			comboBox_fromAcc.Dock = DockStyle.Fill;
			comboBox_fromAcc.FormattingEnabled = true;
			comboBox_fromAcc.Items.AddRange(new object[] { "Mortgage Account", "Checking Account", "Saving Account", "Line Of Credit Account" });
			comboBox_fromAcc.Location = new Point(3, 228);
			comboBox_fromAcc.Name = "comboBox_fromAcc";
			comboBox_fromAcc.Size = new Size(234, 25);
			comboBox_fromAcc.TabIndex = 10;
			comboBox_fromAcc.Text = "From Account";
			// 
			// button9
			// 
			button9.Dock = DockStyle.Fill;
			button9.Font = new Font("Segoe UI Semibold", 10.8679247F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button9.Location = new Point(243, 260);
			button9.Name = "button9";
			button9.Size = new Size(235, 26);
			button9.TabIndex = 8;
			button9.Text = "Transfer";
			button9.UseVisualStyleBackColor = true;
			button9.Click += button9_Click;
			// 
			// panel_Transfer
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel3);
			Name = "panel_Transfer";
			Size = new Size(481, 549);
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
		private TextBox textBox_Amount;
		private Label label2;
		private ComboBox comboBox_fromAcc;
		private Button button9;
		private ComboBox comboBox_toAcc;
	}
}
