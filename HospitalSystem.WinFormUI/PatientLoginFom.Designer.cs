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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxGoster
            // 
            this.cbxGoster.AutoSize = true;
            this.cbxGoster.Location = new System.Drawing.Point(355, 101);
            this.cbxGoster.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGoster.Name = "cbxGoster";
            this.cbxGoster.Size = new System.Drawing.Size(158, 20);
            this.cbxGoster.TabIndex = 26;
            this.cbxGoster.Text = "Hide/Show Password";
            this.cbxGoster.UseVisualStyleBackColor = true;
            this.cbxGoster.CheckedChanged += new System.EventHandler(this.cbxGoster_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(23, 102);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(11, 51);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(114, 16);
            this.lblUserName.TabIndex = 28;
            this.lblUserName.Text = "Patient Username";
            // 
            // btnPatientLogin
            // 
            this.btnPatientLogin.Location = new System.Drawing.Point(133, 158);
            this.btnPatientLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatientLogin.Name = "btnPatientLogin";
            this.btnPatientLogin.Size = new System.Drawing.Size(213, 39);
            this.btnPatientLogin.TabIndex = 27;
            this.btnPatientLogin.Text = "Login";
            this.btnPatientLogin.UseVisualStyleBackColor = true;
            this.btnPatientLogin.Click += new System.EventHandler(this.btnPatientLogin_Click);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(133, 97);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPassword.Multiline = true;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(212, 24);
            this.txtUserPassword.TabIndex = 25;
            // 
            // txtUserName
            // 
            this.txtUserName.AccessibleName = "";
            this.txtUserName.Location = new System.Drawing.Point(133, 48);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(212, 22);
            this.txtUserName.TabIndex = 24;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(133, 222);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(213, 39);
            this.btnSignUp.TabIndex = 27;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // PatientLoginFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 304);
            this.Controls.Add(this.cbxGoster);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnPatientLogin);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnSignUp;
    }
}