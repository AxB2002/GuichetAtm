namespace ATM1
{
	partial class panel_show_balance
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
			tableLayoutPanel4 = new TableLayoutPanel();
			label3 = new Label();
			dataGridView1 = new DataGridView();
			panel3.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb(46, 125, 50);
			panel3.Controls.Add(tableLayoutPanel4);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(815, 579);
			panel3.TabIndex = 6;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 1;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel4.Controls.Add(label3, 0, 1);
			tableLayoutPanel4.Controls.Add(dataGridView1, 0, 2);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(0, 0);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 3;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel4.Size = new Size(815, 579);
			tableLayoutPanel4.TabIndex = 9;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Bottom;
			label3.Font = new Font("Trebuchet MS", 23.7735844F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(3, 57);
			label3.Name = "label3";
			label3.Padding = new Padding(10, 10, 10, 20);
			label3.Size = new Size(809, 57);
			label3.TabIndex = 1;
			label3.Text = "Balance";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(3, 117);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 45;
			dataGridView1.Size = new Size(809, 459);
			dataGridView1.TabIndex = 2;
			// 
			// panel_show_balance
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel3);
			Name = "panel_show_balance";
			Size = new Size(815, 579);
			panel3.ResumeLayout(false);
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel3;
		private TableLayoutPanel tableLayoutPanel4;
		private Label label3;
		private DataGridView dataGridView1;
	}
}
