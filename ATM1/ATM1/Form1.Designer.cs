namespace ATM1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txtCustomerCode = new TextBox();
			txtPIN = new TextBox();
			btnLogin = new Button();
			btnClear = new Button();
			label3 = new Label();
			panel2 = new Panel();
			panel3 = new Panel();
			panel4 = new Panel();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			SuspendLayout();
			// 
			// txtCustomerCode
			// 
			txtCustomerCode.BorderStyle = BorderStyle.None;
			txtCustomerCode.Location = new Point(9, 12);
			txtCustomerCode.Name = "txtCustomerCode";
			txtCustomerCode.PlaceholderText = "Customer ID";
			txtCustomerCode.Size = new Size(370, 18);
			txtCustomerCode.TabIndex = 2;
			// 
			// txtPIN
			// 
			txtPIN.BorderStyle = BorderStyle.None;
			txtPIN.Location = new Point(9, 12);
			txtPIN.Name = "txtPIN";
			txtPIN.PasswordChar = '*';
			txtPIN.PlaceholderText = "PIN";
			txtPIN.Size = new Size(370, 18);
			txtPIN.TabIndex = 3;
			// 
			// btnLogin
			// 
			btnLogin.Anchor = AnchorStyles.None;
			btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnLogin.FlatAppearance.BorderSize = 0;
			btnLogin.Font = new Font("Trebuchet MS", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnLogin.Location = new Point(330, 308);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(142, 56);
			btnLogin.TabIndex = 4;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnClear
			// 
			btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnClear.Font = new Font("Trebuchet MS", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnClear.Location = new Point(685, 402);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(103, 36);
			btnClear.TabIndex = 5;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = SystemColors.ButtonFace;
			label3.Location = new Point(2, 97);
			label3.Name = "label3";
			label3.Size = new Size(797, 62);
			label3.TabIndex = 7;
			label3.Text = "ATM";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			label3.Click += label3_Click;
			// 
			// panel2
			// 
			panel2.Anchor = AnchorStyles.None;
			panel2.BackColor = Color.White;
			panel2.Controls.Add(txtCustomerCode);
			panel2.Location = new Point(211, 169);
			panel2.Name = "panel2";
			panel2.Size = new Size(389, 42);
			panel2.TabIndex = 7;
			// 
			// panel3
			// 
			panel3.Anchor = AnchorStyles.None;
			panel3.BackColor = Color.White;
			panel3.Controls.Add(txtPIN);
			panel3.Location = new Point(211, 240);
			panel3.Name = "panel3";
			panel3.Size = new Size(389, 42);
			panel3.TabIndex = 8;
			// 
			// panel4
			// 
			panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel4.AutoSize = true;
			panel4.BackColor = Color.FromArgb(46, 125, 50);
			panel4.Controls.Add(label3);
			panel4.Controls.Add(panel3);
			panel4.Controls.Add(panel2);
			panel4.Controls.Add(btnLogin);
			panel4.Location = new Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(800, 450);
			panel4.TabIndex = 9;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Green;
			ClientSize = new Size(800, 450);
			Controls.Add(btnClear);
			Controls.Add(panel4);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			WindowState = FormWindowState.Maximized;
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel4.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox txtCustomerCode;
		private TextBox txtPIN;
		private Button btnLogin;
		private Button btnClear;
		private Label label3;
		private Panel panel2;
		private Panel panel3;
		private Panel panel4;
	}
}
