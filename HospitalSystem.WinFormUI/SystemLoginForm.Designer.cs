namespace HospitalSystem.WinFormUI
{
	partial class SystemLoginForm
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
            this.btnDoctorLogin = new System.Windows.Forms.Button();
            this.btnPatientLogin = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoctorLogin
            // 
            this.btnDoctorLogin.Location = new System.Drawing.Point(349, 234);
            this.btnDoctorLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoctorLogin.Name = "btnDoctorLogin";
            this.btnDoctorLogin.Size = new System.Drawing.Size(140, 28);
            this.btnDoctorLogin.TabIndex = 9;
            this.btnDoctorLogin.Text = "Doctor Login Form";
            this.btnDoctorLogin.UseVisualStyleBackColor = true;
            this.btnDoctorLogin.Click += new System.EventHandler(this.btnDoctorLogin_Click);
            // 
            // btnPatientLogin
            // 
            this.btnPatientLogin.Location = new System.Drawing.Point(540, 234);
            this.btnPatientLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPatientLogin.Name = "btnPatientLogin";
            this.btnPatientLogin.Size = new System.Drawing.Size(140, 28);
            this.btnPatientLogin.TabIndex = 8;
            this.btnPatientLogin.Text = "Patient Entry Form";
            this.btnPatientLogin.UseVisualStyleBackColor = true;
            this.btnPatientLogin.Click += new System.EventHandler(this.btnPatientLogin_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(159, 234);
            this.btnAdminLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(140, 28);
            this.btnAdminLogin.TabIndex = 7;
            this.btnAdminLogin.Text = "Admin Login Form";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(135, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please select the form you want to go to below.";
            // 
            // SystemLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 454);
            this.Controls.Add(this.btnDoctorLogin);
            this.Controls.Add(this.btnPatientLogin);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SystemLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDoctorLogin;
		private System.Windows.Forms.Button btnPatientLogin;
		private System.Windows.Forms.Button btnAdminLogin;
		private System.Windows.Forms.Label label1;
	}
}