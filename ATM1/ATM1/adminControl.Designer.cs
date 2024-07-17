namespace ATM1
{
	partial class adminControl
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
			btn_panel = new Panel();
			tableLayoutPanel1 = new TableLayoutPanel();
			button1 = new Button();
			btn_increase_loc = new Button();
			btn_pay_interest = new Button();
			btn_add_money = new Button();
			btn_view_transaction = new Button();
			btn_manage_access = new Button();
			btn_customer_create = new Button();
			btn_create_Account = new Button();
			btn_panel.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// btn_panel
			// 
			btn_panel.AutoSize = true;
			btn_panel.BackColor = Color.FromArgb(255, 255, 128);
			btn_panel.Controls.Add(tableLayoutPanel1);
			btn_panel.Dock = DockStyle.Fill;
			btn_panel.Location = new Point(0, 0);
			btn_panel.Name = "btn_panel";
			btn_panel.Size = new Size(495, 417);
			btn_panel.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.BackColor = Color.FromArgb(46, 125, 50);
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(button1, 1, 4);
			tableLayoutPanel1.Controls.Add(btn_increase_loc, 0, 4);
			tableLayoutPanel1.Controls.Add(btn_pay_interest, 1, 3);
			tableLayoutPanel1.Controls.Add(btn_add_money, 0, 3);
			tableLayoutPanel1.Controls.Add(btn_view_transaction, 0, 2);
			tableLayoutPanel1.Controls.Add(btn_manage_access, 1, 2);
			tableLayoutPanel1.Controls.Add(btn_customer_create, 0, 1);
			tableLayoutPanel1.Controls.Add(btn_create_Account, 1, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.Padding = new Padding(10);
			tableLayoutPanel1.RowCount = 7;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.999752F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999899F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999899F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999899F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999899F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.998899F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.001749F));
			tableLayoutPanel1.Size = new Size(495, 417);
			tableLayoutPanel1.TabIndex = 8;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Fill;
			button1.Location = new Point(250, 229);
			button1.Name = "button1";
			button1.Size = new Size(232, 33);
			button1.TabIndex = 8;
			button1.Text = "Close App";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// btn_increase_loc
			// 
			btn_increase_loc.Dock = DockStyle.Fill;
			btn_increase_loc.Location = new Point(13, 229);
			btn_increase_loc.Name = "btn_increase_loc";
			btn_increase_loc.Size = new Size(231, 33);
			btn_increase_loc.TabIndex = 7;
			btn_increase_loc.Text = "Increase LOC Balance";
			btn_increase_loc.UseVisualStyleBackColor = true;
			btn_increase_loc.Click += btn_increase_loc_Click;
			// 
			// btn_pay_interest
			// 
			btn_pay_interest.Dock = DockStyle.Fill;
			btn_pay_interest.Location = new Point(250, 190);
			btn_pay_interest.Name = "btn_pay_interest";
			btn_pay_interest.Size = new Size(232, 33);
			btn_pay_interest.TabIndex = 5;
			btn_pay_interest.Text = "Pay Interest";
			btn_pay_interest.UseVisualStyleBackColor = true;
			btn_pay_interest.Click += btn_pay_interest_Click;
			// 
			// btn_add_money
			// 
			btn_add_money.Dock = DockStyle.Fill;
			btn_add_money.Location = new Point(13, 190);
			btn_add_money.Name = "btn_add_money";
			btn_add_money.Size = new Size(231, 33);
			btn_add_money.TabIndex = 4;
			btn_add_money.Text = "Add money to ATM";
			btn_add_money.UseVisualStyleBackColor = true;
			btn_add_money.Click += btn_add_money_Click;
			// 
			// btn_view_transaction
			// 
			btn_view_transaction.Dock = DockStyle.Fill;
			btn_view_transaction.Location = new Point(13, 151);
			btn_view_transaction.Name = "btn_view_transaction";
			btn_view_transaction.Size = new Size(231, 33);
			btn_view_transaction.TabIndex = 2;
			btn_view_transaction.Text = "View Transaction";
			btn_view_transaction.UseVisualStyleBackColor = true;
			btn_view_transaction.Click += btn_view_transaction_Click;
			// 
			// btn_manage_access
			// 
			btn_manage_access.Dock = DockStyle.Fill;
			btn_manage_access.Location = new Point(250, 151);
			btn_manage_access.Name = "btn_manage_access";
			btn_manage_access.Size = new Size(232, 33);
			btn_manage_access.TabIndex = 3;
			btn_manage_access.Text = "Manage Access";
			btn_manage_access.UseVisualStyleBackColor = true;
			btn_manage_access.Click += btn_manage_access_Click;
			// 
			// btn_customer_create
			// 
			btn_customer_create.Dock = DockStyle.Fill;
			btn_customer_create.Location = new Point(13, 112);
			btn_customer_create.Name = "btn_customer_create";
			btn_customer_create.Size = new Size(231, 33);
			btn_customer_create.TabIndex = 0;
			btn_customer_create.Text = "Create Customer";
			btn_customer_create.UseVisualStyleBackColor = true;
			btn_customer_create.Click += btn_customer_create_Click;
			// 
			// btn_create_Account
			// 
			btn_create_Account.Dock = DockStyle.Fill;
			btn_create_Account.Location = new Point(250, 112);
			btn_create_Account.Name = "btn_create_Account";
			btn_create_Account.Size = new Size(232, 33);
			btn_create_Account.TabIndex = 1;
			btn_create_Account.Text = "Create Account";
			btn_create_Account.UseVisualStyleBackColor = true;
			btn_create_Account.Click += btn_create_Account_Click;
			// 
			// adminControl
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(btn_panel);
			Name = "adminControl";
			Size = new Size(495, 417);
			btn_panel.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel btn_panel;
		private TableLayoutPanel tableLayoutPanel1;
		private Button btn_increase_loc;
		private Button btn_pay_interest;
		private Button btn_add_money;
		private Button btn_view_transaction;
		private Button btn_manage_access;
		private Button btn_customer_create;
		private Button btn_create_Account;
		private Button button1;
	}
}
