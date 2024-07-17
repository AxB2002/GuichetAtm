namespace ATM1
{
	partial class panel_Account_create
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
			panel1 = new Panel();
			tableLayoutPanel3 = new TableLayoutPanel();
			panel2 = new Panel();
			textBox1 = new TextBox();
			label2 = new Label();
			comboBox3 = new ComboBox();
			button9 = new Button();
			panel1.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(46, 125, 50);
			panel1.Controls.Add(tableLayoutPanel3);
			panel1.Dock = DockStyle.Fill;
			panel1.ImeMode = ImeMode.NoControl;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(604, 599);
			panel1.TabIndex = 3;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 2;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(panel2, 0, 2);
			tableLayoutPanel3.Controls.Add(label2, 0, 1);
			tableLayoutPanel3.Controls.Add(comboBox3, 1, 2);
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
			tableLayoutPanel3.Size = new Size(604, 599);
			tableLayoutPanel3.TabIndex = 9;
			// 
			// panel2
			// 
			panel2.BackColor = Color.White;
			panel2.Controls.Add(textBox1);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(3, 249);
			panel2.Name = "panel2";
			panel2.Size = new Size(296, 29);
			panel2.TabIndex = 11;
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Location = new Point(7, 10);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "Customer ID";
			textBox1.Size = new Size(316, 18);
			textBox1.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Bottom;
			label2.Font = new Font("Trebuchet MS", 23.7735844F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(3, 176);
			label2.Name = "label2";
			label2.Padding = new Padding(10, 10, 10, 20);
			label2.Size = new Size(296, 70);
			label2.TabIndex = 0;
			label2.Text = "Create Account";
			label2.Click += label2_Click;
			// 
			// comboBox3
			// 
			comboBox3.AllowDrop = true;
			comboBox3.Dock = DockStyle.Fill;
			comboBox3.FormattingEnabled = true;
			comboBox3.Items.AddRange(new object[] { "Mortgage Account", "Checking Account", "Saving Account", "Line Of Credit Account" });
			comboBox3.Location = new Point(305, 249);
			comboBox3.Name = "comboBox3";
			comboBox3.Size = new Size(296, 25);
			comboBox3.TabIndex = 10;
			// 
			// button9
			// 
			button9.Dock = DockStyle.Fill;
			button9.Font = new Font("Segoe UI Semibold", 10.8679247F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button9.Location = new Point(3, 284);
			button9.Name = "button9";
			button9.Size = new Size(296, 29);
			button9.TabIndex = 8;
			button9.Text = "Create";
			button9.UseVisualStyleBackColor = true;
			button9.Click += button9_Click;
			// 
			// panel_Account_create
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel1);
			Name = "panel_Account_create";
			Size = new Size(604, 599);
			panel1.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private TableLayoutPanel tableLayoutPanel3;
		private Label label2;
		private ComboBox comboBox3;
		private Button button9;
		private Panel panel2;
		private TextBox textBox1;
	}
}
