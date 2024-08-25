namespace HospitalSystem.WinFormUI
{
    partial class PatientMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblTCKNo = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnPatientAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Username : ";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(152, 36);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(128, 23);
            this.lblUserName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Profile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Surname :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "TCKNo : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Phone : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email : ";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(113, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 23);
            this.lblName.TabIndex = 1;
            // 
            // lblSurname
            // 
            this.lblSurname.Location = new System.Drawing.Point(113, 174);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(128, 23);
            this.lblSurname.TabIndex = 1;
            // 
            // lblTCKNo
            // 
            this.lblTCKNo.Location = new System.Drawing.Point(111, 207);
            this.lblTCKNo.Name = "lblTCKNo";
            this.lblTCKNo.Size = new System.Drawing.Size(128, 23);
            this.lblTCKNo.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(111, 242);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(128, 23);
            this.lblPhone.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(111, 275);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(128, 23);
            this.lblEmail.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(43, 330);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh Screen";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(43, 368);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(128, 23);
            this.btnUpdateProfile.TabIndex = 5;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnPatientAppointment
            // 
            this.btnPatientAppointment.Location = new System.Drawing.Point(399, 190);
            this.btnPatientAppointment.Name = "btnPatientAppointment";
            this.btnPatientAppointment.Size = new System.Drawing.Size(202, 50);
            this.btnPatientAppointment.TabIndex = 6;
            this.btnPatientAppointment.Text = "Go to the patient appointments form!";
            this.btnPatientAppointment.UseVisualStyleBackColor = true;
            this.btnPatientAppointment.Click += new System.EventHandler(this.btnPatientAppointment_Click);
            // 
            // PatientMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 545);
            this.Controls.Add(this.btnPatientAppointment);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblTCKNo);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Name = "PatientMainForm";
            this.Text = "PatientMainForm";
            this.Load += new System.EventHandler(this.PatientMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblTCKNo;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnPatientAppointment;
    }
}