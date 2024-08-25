namespace HospitalSystem.WinFormUI
{
	partial class AdminLoginForm
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
            this.cbxGoster = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxGoster
            // 
            this.cbxGoster.AutoSize = true;
            this.cbxGoster.Location = new System.Drawing.Point(353, 97);
            this.cbxGoster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxGoster.Name = "cbxGoster";
            this.cbxGoster.Size = new System.Drawing.Size(158, 20);
            this.cbxGoster.TabIndex = 14;
            this.cbxGoster.Text = "Hide/Show Password";
            this.cbxGoster.UseVisualStyleBackColor = true;
            this.cbxGoster.CheckedChanged += new System.EventHandler(this.cbxGoster_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 98);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(4, 47);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(111, 16);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "Admin Username";
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(132, 154);
            this.btnAdminLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(213, 39);
            this.btnAdminLogin.TabIndex = 15;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(132, 94);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserPassword.Multiline = true;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(212, 24);
            this.txtUserPassword.TabIndex = 13;
            // 
            // txtUserName
            // 
            this.txtUserName.AccessibleName = "";
            this.txtUserName.Location = new System.Drawing.Point(132, 44);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(212, 22);
            this.txtUserName.TabIndex = 12;
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 248);
            this.Controls.Add(this.cbxGoster);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbxGoster;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Button btnAdminLogin;
		private System.Windows.Forms.TextBox txtUserPassword;
		private System.Windows.Forms.TextBox txtUserName;
	}
}