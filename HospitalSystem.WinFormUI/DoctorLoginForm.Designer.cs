namespace HospitalSystem.WinFormUI
{
	partial class DoctorLoginForm
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
            this.btnDoctorLogin = new System.Windows.Forms.Button();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxGoster
            // 
            this.cbxGoster.AutoSize = true;
            this.cbxGoster.Location = new System.Drawing.Point(355, 84);
            this.cbxGoster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxGoster.Name = "cbxGoster";
            this.cbxGoster.Size = new System.Drawing.Size(158, 20);
            this.cbxGoster.TabIndex = 20;
            this.cbxGoster.Text = "Hide/Show Password";
            this.cbxGoster.UseVisualStyleBackColor = true;
            this.cbxGoster.CheckedChanged += new System.EventHandler(this.cbxGoster_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(21, 89);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(3, 34);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 16);
            this.lblUserName.TabIndex = 22;
            this.lblUserName.Text = "Doctor Username";
            // 
            // btnDoctorLogin
            // 
            this.btnDoctorLogin.Location = new System.Drawing.Point(133, 140);
            this.btnDoctorLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoctorLogin.Name = "btnDoctorLogin";
            this.btnDoctorLogin.Size = new System.Drawing.Size(213, 39);
            this.btnDoctorLogin.TabIndex = 21;
            this.btnDoctorLogin.Text = "Login";
            this.btnDoctorLogin.UseVisualStyleBackColor = true;
            this.btnDoctorLogin.Click += new System.EventHandler(this.btnDoctorLogin_Click);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(133, 80);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserPassword.Multiline = true;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(212, 24);
            this.txtUserPassword.TabIndex = 19;
            // 
            // txtUserName
            // 
            this.txtUserName.AccessibleName = "";
            this.txtUserName.Location = new System.Drawing.Point(133, 31);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(212, 22);
            this.txtUserName.TabIndex = 18;
            // 
            // DoctorLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 225);
            this.Controls.Add(this.cbxGoster);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnDoctorLogin);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoctorLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbxGoster;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Button btnDoctorLogin;
		private System.Windows.Forms.TextBox txtUserPassword;
		private System.Windows.Forms.TextBox txtUserName;
	}
}