namespace ATM1
{
	partial class MainMenu
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			splitContainer1 = new SplitContainer();
			panel2 = new Panel();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(panel2);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(panel1);
			splitContainer1.Size = new Size(800, 450);
			splitContainer1.SplitterDistance = 365;
			splitContainer1.TabIndex = 8;
			// 
			// panel2
			// 
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(365, 450);
			panel2.TabIndex = 0;
			panel2.Paint += panel2_Paint;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(46, 125, 50);
			panel1.Dock = DockStyle.Fill;
			panel1.ImeMode = ImeMode.NoControl;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(431, 450);
			panel1.TabIndex = 11;
			panel1.Visible = false;
			panel1.Paint += panel1_Paint;
			// 
			// MainMenu
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(46, 125, 50);
			ClientSize = new Size(800, 450);
			Controls.Add(splitContainer1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "MainMenu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "z";
			WindowState = FormWindowState.Maximized;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private SplitContainer splitContainer1;
		private Panel panel1;
		private Panel panel2;
	}
}