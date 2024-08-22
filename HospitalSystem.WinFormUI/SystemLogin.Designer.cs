namespace HospitalSystem.WinFormUI
{
	partial class SystemLogin
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
			this.btnDoctorLogin.Location = new System.Drawing.Point(262, 190);
			this.btnDoctorLogin.Name = "btnDoctorLogin";
			this.btnDoctorLogin.Size = new System.Drawing.Size(105, 23);
			this.btnDoctorLogin.TabIndex = 9;
			this.btnDoctorLogin.Text = "Doktor Girişi";
			this.btnDoctorLogin.UseVisualStyleBackColor = true;
			// 
			// btnPatientLogin
			// 
			this.btnPatientLogin.Location = new System.Drawing.Point(405, 190);
			this.btnPatientLogin.Name = "btnPatientLogin";
			this.btnPatientLogin.Size = new System.Drawing.Size(105, 23);
			this.btnPatientLogin.TabIndex = 8;
			this.btnPatientLogin.Text = "Hasta Girişi";
			this.btnPatientLogin.UseVisualStyleBackColor = true;
			// 
			// btnAdminLogin
			// 
			this.btnAdminLogin.Location = new System.Drawing.Point(119, 190);
			this.btnAdminLogin.Name = "btnAdminLogin";
			this.btnAdminLogin.Size = new System.Drawing.Size(105, 23);
			this.btnAdminLogin.TabIndex = 7;
			this.btnAdminLogin.Text = "Admin Girişi";
			this.btnAdminLogin.UseVisualStyleBackColor = true;
			this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(191, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Lütfen Aşağıdan yapmak istediğiniz işlemi seciniz.";
			// 
			// SystemLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 369);
			this.Controls.Add(this.btnDoctorLogin);
			this.Controls.Add(this.btnPatientLogin);
			this.Controls.Add(this.btnAdminLogin);
			this.Controls.Add(this.label1);
			this.Name = "SystemLogin";
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