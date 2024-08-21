namespace HospitalSystem.WinFormUI
{
    partial class PatientAppointmentForm
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
            this.Label2 = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDates = new System.Windows.Forms.ComboBox();
            this.cmbDoctors = new System.Windows.Forms.ComboBox();
            this.lstAppointments = new System.Windows.Forms.ListBox();
            this.btnMakeAnApp = new System.Windows.Forms.Button();
            this.btnCancelApp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(78, 62);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(126, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Patient UserName : ";
            // 
            // lblPatient
            // 
            this.lblPatient.Location = new System.Drawing.Point(217, 62);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(180, 23);
            this.lblPatient.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctor : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date : ";
            // 
            // cmbDates
            // 
            this.cmbDates.FormattingEnabled = true;
            this.cmbDates.Location = new System.Drawing.Point(221, 147);
            this.cmbDates.Name = "cmbDates";
            this.cmbDates.Size = new System.Drawing.Size(181, 24);
            this.cmbDates.TabIndex = 4;
            // 
            // cmbDoctors
            // 
            this.cmbDoctors.FormattingEnabled = true;
            this.cmbDoctors.Location = new System.Drawing.Point(221, 100);
            this.cmbDoctors.Name = "cmbDoctors";
            this.cmbDoctors.Size = new System.Drawing.Size(181, 24);
            this.cmbDoctors.TabIndex = 5;
            this.cmbDoctors.SelectedIndexChanged += new System.EventHandler(this.cmbDoctors_SelectedIndexChanged);
            // 
            // lstAppointments
            // 
            this.lstAppointments.FormattingEnabled = true;
            this.lstAppointments.ItemHeight = 16;
            this.lstAppointments.Location = new System.Drawing.Point(453, 59);
            this.lstAppointments.Name = "lstAppointments";
            this.lstAppointments.Size = new System.Drawing.Size(281, 308);
            this.lstAppointments.TabIndex = 6;
            // 
            // btnMakeAnApp
            // 
            this.btnMakeAnApp.Location = new System.Drawing.Point(217, 234);
            this.btnMakeAnApp.Name = "btnMakeAnApp";
            this.btnMakeAnApp.Size = new System.Drawing.Size(181, 32);
            this.btnMakeAnApp.TabIndex = 7;
            this.btnMakeAnApp.Text = "Make an Appointment";
            this.btnMakeAnApp.UseVisualStyleBackColor = true;
            this.btnMakeAnApp.Click += new System.EventHandler(this.btnMakeAnApp_Click);
            // 
            // btnCancelApp
            // 
            this.btnCancelApp.Location = new System.Drawing.Point(217, 284);
            this.btnCancelApp.Name = "btnCancelApp";
            this.btnCancelApp.Size = new System.Drawing.Size(181, 26);
            this.btnCancelApp.TabIndex = 7;
            this.btnCancelApp.Text = "Cancel Appointment";
            this.btnCancelApp.UseVisualStyleBackColor = true;
            this.btnCancelApp.Click += new System.EventHandler(this.btnCancelApp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patient Appointments";
            // 
            // PatientAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelApp);
            this.Controls.Add(this.btnMakeAnApp);
            this.Controls.Add(this.lstAppointments);
            this.Controls.Add(this.cmbDoctors);
            this.Controls.Add(this.cmbDates);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.Label2);
            this.Name = "PatientAppointmentForm";
            this.Text = "PatientAppointmentForm";
            this.Load += new System.EventHandler(this.PatientAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDates;
        private System.Windows.Forms.ComboBox cmbDoctors;
        private System.Windows.Forms.ListBox lstAppointments;
        private System.Windows.Forms.Button btnMakeAnApp;
        private System.Windows.Forms.Button btnCancelApp;
        private System.Windows.Forms.Label label4;
    }
}