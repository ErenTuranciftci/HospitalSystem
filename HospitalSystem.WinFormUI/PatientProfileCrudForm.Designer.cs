namespace HospitalSystem.WinFormUI
{
    partial class PatientProfileCrudForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPatients = new System.Windows.Forms.ComboBox();
            this.btnModifieds = new System.Windows.Forms.Button();
            this.btnDestory = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPassives = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnActives = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstPatientProfiles = new System.Windows.Forms.ListBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTCKNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(212, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 66;
            this.label5.Text = "Patients";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(51, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 65;
            this.label4.Text = "Surname";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(186, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 64;
            this.label3.Text = "Phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(186, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPatients
            // 
            this.cmbPatients.FormattingEnabled = true;
            this.cmbPatients.Location = new System.Drawing.Point(204, 349);
            this.cmbPatients.Name = "cmbPatients";
            this.cmbPatients.Size = new System.Drawing.Size(121, 21);
            this.cmbPatients.TabIndex = 61;
            this.cmbPatients.SelectedIndexChanged += new System.EventHandler(this.cmbPatients_SelectedIndexChanged);
            // 
            // btnModifieds
            // 
            this.btnModifieds.Location = new System.Drawing.Point(291, 269);
            this.btnModifieds.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifieds.Name = "btnModifieds";
            this.btnModifieds.Size = new System.Drawing.Size(93, 28);
            this.btnModifieds.TabIndex = 52;
            this.btnModifieds.Text = "Modifieds";
            this.btnModifieds.UseVisualStyleBackColor = true;
            this.btnModifieds.Click += new System.EventHandler(this.btnModifieds_Click);
            // 
            // btnDestory
            // 
            this.btnDestory.Location = new System.Drawing.Point(153, 269);
            this.btnDestory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDestory.Name = "btnDestory";
            this.btnDestory.Size = new System.Drawing.Size(93, 28);
            this.btnDestory.TabIndex = 53;
            this.btnDestory.Text = "Destroy";
            this.btnDestory.UseVisualStyleBackColor = true;
            this.btnDestory.Click += new System.EventHandler(this.btnDestory_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(153, 237);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 28);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPassives
            // 
            this.btnPassives.Location = new System.Drawing.Point(291, 237);
            this.btnPassives.Margin = new System.Windows.Forms.Padding(2);
            this.btnPassives.Name = "btnPassives";
            this.btnPassives.Size = new System.Drawing.Size(93, 28);
            this.btnPassives.TabIndex = 55;
            this.btnPassives.Text = "Passives";
            this.btnPassives.UseVisualStyleBackColor = true;
            this.btnPassives.Click += new System.EventHandler(this.btnPassives_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(153, 205);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 28);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(291, 171);
            this.btnGetAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(93, 28);
            this.btnGetAll.TabIndex = 57;
            this.btnGetAll.Text = "All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnActives
            // 
            this.btnActives.Location = new System.Drawing.Point(291, 205);
            this.btnActives.Margin = new System.Windows.Forms.Padding(2);
            this.btnActives.Name = "btnActives";
            this.btnActives.Size = new System.Drawing.Size(93, 28);
            this.btnActives.TabIndex = 58;
            this.btnActives.Text = "Actives";
            this.btnActives.UseVisualStyleBackColor = true;
            this.btnActives.Click += new System.EventHandler(this.btnActives_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(153, 171);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 28);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstPatientProfiles
            // 
            this.lstPatientProfiles.FormattingEnabled = true;
            this.lstPatientProfiles.Location = new System.Drawing.Point(463, 77);
            this.lstPatientProfiles.Margin = new System.Windows.Forms.Padding(2);
            this.lstPatientProfiles.Name = "lstPatientProfiles";
            this.lstPatientProfiles.Size = new System.Drawing.Size(222, 303);
            this.lstPatientProfiles.TabIndex = 51;
            this.lstPatientProfiles.Click += new System.EventHandler(this.lstPatientProfiles_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(189, 129);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(113, 20);
            this.txtPhone.TabIndex = 47;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 76);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(113, 20);
            this.txtEmail.TabIndex = 50;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(51, 129);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(113, 20);
            this.txtSurname.TabIndex = 48;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(51, 76);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(113, 20);
            this.txtName.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(321, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 63;
            this.label7.Text = "TCKNo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTCKNo
            // 
            this.txtTCKNo.Location = new System.Drawing.Point(324, 77);
            this.txtTCKNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTCKNo.Name = "txtTCKNo";
            this.txtTCKNo.Size = new System.Drawing.Size(113, 20);
            this.txtTCKNo.TabIndex = 50;
            // 
            // PatientProfileCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPatients);
            this.Controls.Add(this.btnModifieds);
            this.Controls.Add(this.btnDestory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPassives);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.btnActives);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstPatientProfiles);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtTCKNo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Name = "PatientProfileCrudForm";
            this.Text = "PatientProfileCrudForm";
            this.Load += new System.EventHandler(this.PatientProfileCrudForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPatients;
        private System.Windows.Forms.Button btnModifieds;
        private System.Windows.Forms.Button btnDestory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPassives;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnActives;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstPatientProfiles;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTCKNo;
    }
}