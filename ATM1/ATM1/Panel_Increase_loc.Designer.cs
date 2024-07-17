namespace ATM1
{
	partial class Panel_Increase_loc
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
			tableLayoutPanel13 = new TableLayoutPanel();
			tableLayoutPanel14 = new TableLayoutPanel();
			label18 = new Label();
			panel1.SuspendLayout();
			tableLayoutPanel13.SuspendLayout();
			tableLayoutPanel14.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(46, 125, 50);
			panel1.Controls.Add(tableLayoutPanel13);
			panel1.Dock = DockStyle.Fill;
			panel1.ImeMode = ImeMode.NoControl;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(150, 150);
			panel1.TabIndex = 9;
			// 
			// tableLayoutPanel13
			// 
			tableLayoutPanel13.ColumnCount = 1;
			tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel13.Controls.Add(tableLayoutPanel14, 0, 1);
			tableLayoutPanel13.Dock = DockStyle.Fill;
			tableLayoutPanel13.Location = new Point(0, 0);
			tableLayoutPanel13.Name = "tableLayoutPanel13";
			tableLayoutPanel13.RowCount = 3;
			tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 81.8181839F));
			tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel13.Size = new Size(150, 150);
			tableLayoutPanel13.TabIndex = 9;
			// 
			// tableLayoutPanel14
			// 
			tableLayoutPanel14.ColumnCount = 1;
			tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel14.Controls.Add(label18, 0, 3);
			tableLayoutPanel14.Dock = DockStyle.Fill;
			tableLayoutPanel14.Location = new Point(3, 16);
			tableLayoutPanel14.Name = "tableLayoutPanel14";
			tableLayoutPanel14.RowCount = 7;
			tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6721363F));
			tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6721325F));
			tableLayoutPanel14.Size = new Size(144, 116);
			tableLayoutPanel14.TabIndex = 2;
			// 
			// label18
			// 
			label18.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label18.AutoSize = true;
			label18.Font = new Font("Trebuchet MS", 23.7735844F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label18.ForeColor = Color.White;
			label18.Location = new Point(3, 50);
			label18.Name = "label18";
			label18.Padding = new Padding(10, 10, 10, 20);
			label18.Size = new Size(138, 14);
			label18.TabIndex = 1;
			label18.Text = "5% LOC Balance Increased for All Acounts";
			// 
			// Panel_Increase_loc
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel1);
			Name = "Panel_Increase_loc";
			panel1.ResumeLayout(false);
			tableLayoutPanel13.ResumeLayout(false);
			tableLayoutPanel14.ResumeLayout(false);
			tableLayoutPanel14.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private TableLayoutPanel tableLayoutPanel13;
		private TableLayoutPanel tableLayoutPanel14;
		private Label label18;
	}
}
