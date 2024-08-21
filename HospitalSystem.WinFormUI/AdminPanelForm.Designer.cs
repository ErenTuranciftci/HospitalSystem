namespace HospitalSystem.WinFormUI
{
    partial class AdminPanelForm
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
            this.btnPatientCrud = new System.Windows.Forms.Button();
            this.btnDoctorCrud = new System.Windows.Forms.Button();
            this.btnPatientProfileCrud = new System.Windows.Forms.Button();
            this.btnDoctorProfileCrud = new System.Windows.Forms.Button();
            this.btnAppointmentCrud = new System.Windows.Forms.Button();
            this.btnDepartmentCrud = new System.Windows.Forms.Button();
            this.btnAdminCrud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(182, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPatientCrud
            // 
            this.btnPatientCrud.Location = new System.Drawing.Point(261, 146);
            this.btnPatientCrud.Name = "btnPatientCrud";
            this.btnPatientCrud.Size = new System.Drawing.Size(116, 23);
            this.btnPatientCrud.TabIndex = 1;
            this.btnPatientCrud.Text = "PatientCrudd";
            this.btnPatientCrud.UseVisualStyleBackColor = true;
            this.btnPatientCrud.Click += new System.EventHandler(this.btnPatientCrud_Click);
            // 
            // btnDoctorCrud
            // 
            this.btnDoctorCrud.Location = new System.Drawing.Point(389, 146);
            this.btnDoctorCrud.Name = "btnDoctorCrud";
            this.btnDoctorCrud.Size = new System.Drawing.Size(116, 23);
            this.btnDoctorCrud.TabIndex = 1;
            this.btnDoctorCrud.Text = "DoctorCrud";
            this.btnDoctorCrud.UseVisualStyleBackColor = true;
            this.btnDoctorCrud.Click += new System.EventHandler(this.btnDoctorCrud_Click);
            // 
            // btnPatientProfileCrud
            // 
            this.btnPatientProfileCrud.Location = new System.Drawing.Point(261, 196);
            this.btnPatientProfileCrud.Name = "btnPatientProfileCrud";
            this.btnPatientProfileCrud.Size = new System.Drawing.Size(116, 23);
            this.btnPatientProfileCrud.TabIndex = 1;
            this.btnPatientProfileCrud.Text = "PatientProfileCrud";
            this.btnPatientProfileCrud.UseVisualStyleBackColor = true;
            this.btnPatientProfileCrud.Click += new System.EventHandler(this.btnPatientProfileCrud_Click);
            // 
            // btnDoctorProfileCrud
            // 
            this.btnDoctorProfileCrud.Location = new System.Drawing.Point(389, 196);
            this.btnDoctorProfileCrud.Name = "btnDoctorProfileCrud";
            this.btnDoctorProfileCrud.Size = new System.Drawing.Size(116, 23);
            this.btnDoctorProfileCrud.TabIndex = 1;
            this.btnDoctorProfileCrud.Text = "DoctorProfileCrub";
            this.btnDoctorProfileCrud.UseVisualStyleBackColor = true;
            this.btnDoctorProfileCrud.Click += new System.EventHandler(this.btnDoctorProfileCrud_Click);
            // 
            // btnAppointmentCrud
            // 
            this.btnAppointmentCrud.Location = new System.Drawing.Point(261, 253);
            this.btnAppointmentCrud.Name = "btnAppointmentCrud";
            this.btnAppointmentCrud.Size = new System.Drawing.Size(116, 23);
            this.btnAppointmentCrud.TabIndex = 1;
            this.btnAppointmentCrud.Text = "AppointmentCrud";
            this.btnAppointmentCrud.UseVisualStyleBackColor = true;
            this.btnAppointmentCrud.Click += new System.EventHandler(this.btnAppointmentCrud_Click);
            // 
            // btnDepartmentCrud
            // 
            this.btnDepartmentCrud.Location = new System.Drawing.Point(389, 253);
            this.btnDepartmentCrud.Name = "btnDepartmentCrud";
            this.btnDepartmentCrud.Size = new System.Drawing.Size(116, 23);
            this.btnDepartmentCrud.TabIndex = 1;
            this.btnDepartmentCrud.Text = "DepartmentCrud";
            this.btnDepartmentCrud.UseVisualStyleBackColor = true;
            this.btnDepartmentCrud.Click += new System.EventHandler(this.btnDepartmentCrud_Click);
            // 
            // btnAdminCrud
            // 
            this.btnAdminCrud.Location = new System.Drawing.Point(323, 307);
            this.btnAdminCrud.Name = "btnAdminCrud";
            this.btnAdminCrud.Size = new System.Drawing.Size(116, 23);
            this.btnAdminCrud.TabIndex = 1;
            this.btnAdminCrud.Text = "AdminCrud";
            this.btnAdminCrud.UseVisualStyleBackColor = true;
            this.btnAdminCrud.Click += new System.EventHandler(this.btnAdminCrud_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoctorProfileCrud);
            this.Controls.Add(this.btnAdminCrud);
            this.Controls.Add(this.btnDepartmentCrud);
            this.Controls.Add(this.btnPatientProfileCrud);
            this.Controls.Add(this.btnAppointmentCrud);
            this.Controls.Add(this.btnDoctorCrud);
            this.Controls.Add(this.btnPatientCrud);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPatientCrud;
        private System.Windows.Forms.Button btnDoctorCrud;
        private System.Windows.Forms.Button btnPatientProfileCrud;
        private System.Windows.Forms.Button btnDoctorProfileCrud;
        private System.Windows.Forms.Button btnAppointmentCrud;
        private System.Windows.Forms.Button btnDepartmentCrud;
        private System.Windows.Forms.Button btnAdminCrud;
    }
}