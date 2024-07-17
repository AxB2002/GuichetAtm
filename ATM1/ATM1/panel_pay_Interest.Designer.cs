namespace ATM1
{
	partial class panel_pay_Interest
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
			tableLayoutPanel9 = new TableLayoutPanel();
			tableLayoutPanel10 = new TableLayoutPanel();
			label10 = new Label();
			panel1.SuspendLayout();
			tableLayoutPanel9.SuspendLayout();
			tableLayoutPanel10.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(46, 125, 50);
			panel1.Controls.Add(tableLayoutPanel9);
			panel1.Dock = DockStyle.Fill;
			panel1.ImeMode = ImeMode.NoControl;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(527, 546);
			panel1.TabIndex = 7;
			// 
			// tableLayoutPanel9
			// 
			tableLayoutPanel9.ColumnCount = 1;
			tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 1);
			tableLayoutPanel9.Dock = DockStyle.Fill;
			tableLayoutPanel9.Location = new Point(0, 0);
			tableLayoutPanel9.Name = "tableLayoutPanel9";
			tableLayoutPanel9.RowCount = 3;
			tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 81.8181839F));
			tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel9.Size = new Size(527, 546);
			tableLayoutPanel9.TabIndex = 9;
			// 
			// tableLayoutPanel10
			// 
			tableLayoutPanel10.ColumnCount = 1;
			tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel10.Controls.Add(label10, 0, 3);
			tableLayoutPanel10.Dock = DockStyle.Fill;
			tableLayoutPanel10.Location = new Point(3, 52);
			tableLayoutPanel10.Name = "tableLayoutPanel10";
			tableLayoutPanel10.RowCount = 7;
			tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6721363F));
			tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1311474F));
			tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6721325F));
			tableLayoutPanel10.Size = new Size(521, 440);
			tableLayoutPanel10.TabIndex = 2;
			// 
			// label10
			// 
			label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label10.AutoSize = true;
			label10.Font = new Font("Trebuchet MS", 23.7735844F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label10.ForeColor = Color.White;
			label10.Location = new Point(3, 192);
			label10.Name = "label10";
			label10.Padding = new Padding(10, 10, 10, 20);
			label10.Size = new Size(515, 53);
			label10.TabIndex = 1;
			label10.Text = "1% Interest Added to All Acounts";
			// 
			// panel_pay_Interest
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel1);
			Name = "panel_pay_Interest";
			Size = new Size(527, 546);
			panel1.ResumeLayout(false);
			tableLayoutPanel9.ResumeLayout(false);
			tableLayoutPanel10.ResumeLayout(false);
			tableLayoutPanel10.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private TableLayoutPanel tableLayoutPanel9;
		private TableLayoutPanel tableLayoutPanel10;
		private Label label10;
	}
}
