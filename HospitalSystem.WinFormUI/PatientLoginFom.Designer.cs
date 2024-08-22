namespace HospitalSystem.WinFormUI
{
	partial class PatientLoginFom
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
			this.btnPatientLogin = new System.Windows.Forms.Button();
			this.txtUserPassword = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cbxGoster
			// 
			this.cbxGoster.AutoSize = true;
			this.cbxGoster.Location = new System.Drawing.Point(266, 82);
			this.cbxGoster.Name = "cbxGoster";
			this.cbxGoster.Size = new System.Drawing.Size(97, 17);
			this.cbxGoster.TabIndex = 26;
			this.cbxGoster.Text = "Parolayı Göster";
			this.cbxGoster.UseVisualStyleBackColor = true;
			this.cbxGoster.CheckedChanged += new System.EventHandler(this.cbxGoster_CheckedChanged);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(16, 86);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(28, 13);
			this.lblPassword.TabIndex = 29;
			this.lblPassword.Text = "Şifre";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(16, 45);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(64, 13);
			this.lblUserName.TabIndex = 28;
			this.lblUserName.Text = "Kullanıcı Adı";
			// 
			// btnPatientLogin
			// 
			this.btnPatientLogin.Location = new System.Drawing.Point(100, 128);
			this.btnPatientLogin.Name = "btnPatientLogin";
			this.btnPatientLogin.Size = new System.Drawing.Size(160, 32);
			this.btnPatientLogin.TabIndex = 27;
			this.btnPatientLogin.Text = "Giriş";
			this.btnPatientLogin.UseVisualStyleBackColor = true;
			this.btnPatientLogin.Click += new System.EventHandler(this.btnPatientLogin_Click);
			// 
			// txtUserPassword
			// 
			this.txtUserPassword.Location = new System.Drawing.Point(100, 79);
			this.txtUserPassword.Multiline = true;
			this.txtUserPassword.Name = "txtUserPassword";
			this.txtUserPassword.PasswordChar = '*';
			this.txtUserPassword.Size = new System.Drawing.Size(160, 20);
			this.txtUserPassword.TabIndex = 25;
			// 
			// txtUserName
			// 
			this.txtUserName.AccessibleName = "";
			this.txtUserName.Location = new System.Drawing.Point(100, 39);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(160, 20);
			this.txtUserName.TabIndex = 24;
			// 
			// PatientLoginFom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 194);
			this.Controls.Add(this.cbxGoster);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.btnPatientLogin);
			this.Controls.Add(this.txtUserPassword);
			this.Controls.Add(this.txtUserName);
			this.Name = "PatientLoginFom";
			this.Text = "Patient Login Fom";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbxGoster;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Button btnPatientLogin;
		private System.Windows.Forms.TextBox txtUserPassword;
		private System.Windows.Forms.TextBox txtUserName;
	}
}