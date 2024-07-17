namespace ATM1
{
	partial class UserOptions
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
			panel2 = new Panel();
			tableLayoutPanel2 = new TableLayoutPanel();
			btn_ShowBalance = new Button();
			btn_Bill_Payment = new Button();
			btn_Transfer = new Button();
			btn_Deposit = new Button();
			btn_WithDraw = new Button();
			panel2.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.AutoSize = true;
			panel2.BackColor = Color.FromArgb(255, 255, 128);
			panel2.Controls.Add(tableLayoutPanel2);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(417, 418);
			panel2.TabIndex = 10;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.BackColor = Color.FromArgb(46, 125, 50);
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(btn_ShowBalance, 0, 3);
			tableLayoutPanel2.Controls.Add(btn_Bill_Payment, 0, 2);
			tableLayoutPanel2.Controls.Add(btn_Transfer, 1, 2);
			tableLayoutPanel2.Controls.Add(btn_Deposit, 0, 1);
			tableLayoutPanel2.Controls.Add(btn_WithDraw, 1, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(0, 0);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.Padding = new Padding(10);
			tableLayoutPanel2.RowCount = 6;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.7777786F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.7777786F));
			tableLayoutPanel2.Size = new Size(417, 418);
			tableLayoutPanel2.TabIndex = 8;
			// 
			// btn_ShowBalance
			// 
			btn_ShowBalance.Dock = DockStyle.Fill;
			btn_ShowBalance.Location = new Point(13, 211);
			btn_ShowBalance.Name = "btn_ShowBalance";
			btn_ShowBalance.Size = new Size(192, 38);
			btn_ShowBalance.TabIndex = 4;
			btn_ShowBalance.Text = "Show balance";
			btn_ShowBalance.UseVisualStyleBackColor = true;
			btn_ShowBalance.Click += btn_ShowBalance_Click;
			// 
			// btn_Bill_Payment
			// 
			btn_Bill_Payment.Dock = DockStyle.Fill;
			btn_Bill_Payment.Location = new Point(13, 167);
			btn_Bill_Payment.Name = "btn_Bill_Payment";
			btn_Bill_Payment.Size = new Size(192, 38);
			btn_Bill_Payment.TabIndex = 2;
			btn_Bill_Payment.Text = "Bill Payment";
			btn_Bill_Payment.UseVisualStyleBackColor = true;
			btn_Bill_Payment.Click += btn_Bill_Payment_Click;
			// 
			// btn_Transfer
			// 
			btn_Transfer.Dock = DockStyle.Fill;
			btn_Transfer.Location = new Point(211, 167);
			btn_Transfer.Name = "btn_Transfer";
			btn_Transfer.Size = new Size(193, 38);
			btn_Transfer.TabIndex = 3;
			btn_Transfer.Text = "Transfer";
			btn_Transfer.UseVisualStyleBackColor = true;
			btn_Transfer.Click += btn_Transfer_Click;
			// 
			// btn_Deposit
			// 
			btn_Deposit.Dock = DockStyle.Fill;
			btn_Deposit.Location = new Point(13, 123);
			btn_Deposit.Name = "btn_Deposit";
			btn_Deposit.Size = new Size(192, 38);
			btn_Deposit.TabIndex = 0;
			btn_Deposit.Text = "Deposit";
			btn_Deposit.UseVisualStyleBackColor = true;
			btn_Deposit.Click += btn_Deposit_Click;
			// 
			// btn_WithDraw
			// 
			btn_WithDraw.Dock = DockStyle.Fill;
			btn_WithDraw.Location = new Point(211, 123);
			btn_WithDraw.Name = "btn_WithDraw";
			btn_WithDraw.Size = new Size(193, 38);
			btn_WithDraw.TabIndex = 1;
			btn_WithDraw.Text = "WithDraw";
			btn_WithDraw.UseVisualStyleBackColor = true;
			btn_WithDraw.Click += btn_WithDraw_Click;
			// 
			// UserOptions
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel2);
			Name = "UserOptions";
			Size = new Size(417, 418);
			panel2.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel2;
		private TableLayoutPanel tableLayoutPanel2;
		private Button btn_ShowBalance;
		private Button btn_Bill_Payment;
		private Button btn_Transfer;
		private Button btn_Deposit;
		private Button btn_WithDraw;
	}
}
