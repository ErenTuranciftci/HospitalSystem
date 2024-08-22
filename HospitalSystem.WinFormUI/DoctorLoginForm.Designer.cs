namespace HospitalSystem.WinFormUI
{
	partial class doctorLoginForm
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
			this.cbxGoster.Location = new System.Drawing.Point(266, 68);
			this.cbxGoster.Name = "cbxGoster";
			this.cbxGoster.Size = new System.Drawing.Size(97, 17);
			this.cbxGoster.TabIndex = 20;
			this.cbxGoster.Text = "Parolayı Göster";
			this.cbxGoster.UseVisualStyleBackColor = true;
			this.cbxGoster.CheckedChanged += new System.EventHandler(this.cbxGoster_CheckedChanged);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(16, 72);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(28, 13);
			this.lblPassword.TabIndex = 23;
			this.lblPassword.Text = "Şifre";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(16, 31);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(64, 13);
			this.lblUserName.TabIndex = 22;
			this.lblUserName.Text = "Kullanıcı Adı";
			// 
			// btnDoctorLogin
			// 
			this.btnDoctorLogin.Location = new System.Drawing.Point(100, 114);
			this.btnDoctorLogin.Name = "btnDoctorLogin";
			this.btnDoctorLogin.Size = new System.Drawing.Size(160, 32);
			this.btnDoctorLogin.TabIndex = 21;
			this.btnDoctorLogin.Text = "Giriş";
			this.btnDoctorLogin.UseVisualStyleBackColor = true;
			this.btnDoctorLogin.Click += new System.EventHandler(this.btnDoctorLogin_Click);
			// 
			// txtUserPassword
			// 
			this.txtUserPassword.Location = new System.Drawing.Point(100, 65);
			this.txtUserPassword.Multiline = true;
			this.txtUserPassword.Name = "txtUserPassword";
			this.txtUserPassword.PasswordChar = '*';
			this.txtUserPassword.Size = new System.Drawing.Size(160, 20);
			this.txtUserPassword.TabIndex = 19;
			// 
			// txtUserName
			// 
			this.txtUserName.AccessibleName = "";
			this.txtUserName.Location = new System.Drawing.Point(100, 25);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(160, 20);
			this.txtUserName.TabIndex = 18;
			// 
			// doctorLoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 183);
			this.Controls.Add(this.cbxGoster);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.btnDoctorLogin);
			this.Controls.Add(this.txtUserPassword);
			this.Controls.Add(this.txtUserName);
			this.Name = "doctorLoginForm";
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