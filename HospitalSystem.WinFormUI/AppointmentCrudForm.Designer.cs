namespace HospitalSystem.WinFormUI
{
    partial class AppointmentCrudForm
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
            this.cmbDates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDoctors = new System.Windows.Forms.ComboBox();
            this.lstAppointments = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnActives = new System.Windows.Forms.Button();
            this.btnPassives = new System.Windows.Forms.Button();
            this.btnModifieds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDates
            // 
            this.cmbDates.FormattingEnabled = true;
            this.cmbDates.Location = new System.Drawing.Point(259, 66);
            this.cmbDates.Name = "cmbDates";
            this.cmbDates.Size = new System.Drawing.Size(211, 24);
            this.cmbDates.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointment Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doctor : ";
            // 
            // cmbDoctors
            // 
            this.cmbDoctors.FormattingEnabled = true;
            this.cmbDoctors.Location = new System.Drawing.Point(259, 107);
            this.cmbDoctors.Name = "cmbDoctors";
            this.cmbDoctors.Size = new System.Drawing.Size(211, 24);
            this.cmbDoctors.TabIndex = 0;
            this.cmbDoctors.SelectedIndexChanged += new System.EventHandler(this.cmbDoctors_SelectedIndexChanged);
            // 
            // lstAppointments
            // 
            this.lstAppointments.FormattingEnabled = true;
            this.lstAppointments.ItemHeight = 16;
            this.lstAppointments.Location = new System.Drawing.Point(524, 66);
            this.lstAppointments.Name = "lstAppointments";
            this.lstAppointments.Size = new System.Drawing.Size(359, 404);
            this.lstAppointments.TabIndex = 3;
            this.lstAppointments.Click += new System.EventHandler(this.lstAppointments_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(195, 193);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(97, 31);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(195, 235);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 31);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(195, 276);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(195, 323);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(97, 28);
            this.btnDestroy.TabIndex = 4;
            this.btnDestroy.Text = "Destroy";
            this.btnDestroy.UseVisualStyleBackColor = true;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(373, 193);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(97, 31);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnActives
            // 
            this.btnActives.Location = new System.Drawing.Point(373, 235);
            this.btnActives.Name = "btnActives";
            this.btnActives.Size = new System.Drawing.Size(97, 31);
            this.btnActives.TabIndex = 4;
            this.btnActives.Text = "Actives";
            this.btnActives.UseVisualStyleBackColor = true;
            this.btnActives.Click += new System.EventHandler(this.btnActives_Click);
            // 
            // btnPassives
            // 
            this.btnPassives.Location = new System.Drawing.Point(373, 276);
            this.btnPassives.Name = "btnPassives";
            this.btnPassives.Size = new System.Drawing.Size(97, 34);
            this.btnPassives.TabIndex = 4;
            this.btnPassives.Text = "Passives";
            this.btnPassives.UseVisualStyleBackColor = true;
            this.btnPassives.Click += new System.EventHandler(this.btnPassives_Click);
            // 
            // btnModifieds
            // 
            this.btnModifieds.Location = new System.Drawing.Point(373, 323);
            this.btnModifieds.Name = "btnModifieds";
            this.btnModifieds.Size = new System.Drawing.Size(97, 28);
            this.btnModifieds.TabIndex = 4;
            this.btnModifieds.Text = "Modifieds";
            this.btnModifieds.UseVisualStyleBackColor = true;
            this.btnModifieds.Click += new System.EventHandler(this.btnModifieds_Click);
            // 
            // AppointmentCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 591);
            this.Controls.Add(this.btnModifieds);
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.btnPassives);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnActives);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lstAppointments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDoctors);
            this.Controls.Add(this.cmbDates);
            this.Name = "AppointmentCrudForm";
            this.Text = "AppointmentCrudForm";
            this.Load += new System.EventHandler(this.AppointmentCrudForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDoctors;
        private System.Windows.Forms.ListBox lstAppointments;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnActives;
        private System.Windows.Forms.Button btnPassives;
        private System.Windows.Forms.Button btnModifieds;
    }
}