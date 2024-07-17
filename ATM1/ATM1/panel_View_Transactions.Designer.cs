namespace ATM1
{
	partial class panel_View_Transactions
	{
		private System.ComponentModel.IContainer components = null;
		private DataGridView dataGridView1;
		private Panel panel1;
		private TableLayoutPanel tableLayoutPanel4;
		private Label label3;

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
			panel1 = new Panel();
			tableLayoutPanel4 = new TableLayoutPanel();
			label3 = new Label();
			dataGridView1 = new DataGridView();
			panel1.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			SuspendLayout();

			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(46, 125, 50);
			panel1.Controls.Add(tableLayoutPanel4);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(450, 497);
			panel1.TabIndex = 4;

			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 1;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel4.Controls.Add(label3, 0, 0);
			tableLayoutPanel4.Controls.Add(dataGridView1, 0, 1);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(0, 0);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 2;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
			tableLayoutPanel4.Size = new Size(450, 497);
			tableLayoutPanel4.TabIndex = 9;

			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Bottom;
			label3.Font = new Font("Trebuchet MS", 23.7735844F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(3, 0);
			label3.Name = "label3";
			label3.Padding = new Padding(10, 10, 10, 20);
			label3.Size = new Size(444, 49);
			label3.TabIndex = 1;
			label3.Text = "Transaction List";

			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(3, 52);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(444, 442);
			dataGridView1.TabIndex = 2;

			// 
			// panel_View_Transactions
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel1);
			Name = "panel_View_Transactions";
			Size = new Size(450, 497);
			panel1.ResumeLayout(false);
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			ResumeLayout(false);
		}
	}
}
