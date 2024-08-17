namespace HospitalSystem.WinFormUI
{
    partial class DoctorCrudForm
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
            this.btnModifieds = new System.Windows.Forms.Button();
            this.btnDestory = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPassives = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnActives = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstDoctors = new System.Windows.Forms.ListBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnModifieds
            // 
            this.btnModifieds.Location = new System.Drawing.Point(277, 243);
            this.btnModifieds.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifieds.Name = "btnModifieds";
            this.btnModifieds.Size = new System.Drawing.Size(93, 28);
            this.btnModifieds.TabIndex = 15;
            this.btnModifieds.Text = "Modifieds";
            this.btnModifieds.UseVisualStyleBackColor = true;
            this.btnModifieds.Click += new System.EventHandler(this.btnModifieds_Click);
            // 
            // btnDestory
            // 
            this.btnDestory.Location = new System.Drawing.Point(139, 243);
            this.btnDestory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDestory.Name = "btnDestory";
            this.btnDestory.Size = new System.Drawing.Size(93, 28);
            this.btnDestory.TabIndex = 16;
            this.btnDestory.Text = "Destroy";
            this.btnDestory.UseVisualStyleBackColor = true;
            this.btnDestory.Click += new System.EventHandler(this.btnDestory_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(139, 211);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 28);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPassives
            // 
            this.btnPassives.Location = new System.Drawing.Point(277, 211);
            this.btnPassives.Margin = new System.Windows.Forms.Padding(2);
            this.btnPassives.Name = "btnPassives";
            this.btnPassives.Size = new System.Drawing.Size(93, 28);
            this.btnPassives.TabIndex = 18;
            this.btnPassives.Text = "Passives";
            this.btnPassives.UseVisualStyleBackColor = true;
            this.btnPassives.Click += new System.EventHandler(this.btnPassives_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(139, 179);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 28);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(277, 145);
            this.btnGetAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(93, 28);
            this.btnGetAll.TabIndex = 20;
            this.btnGetAll.Text = "All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnActives
            // 
            this.btnActives.Location = new System.Drawing.Point(277, 179);
            this.btnActives.Margin = new System.Windows.Forms.Padding(2);
            this.btnActives.Name = "btnActives";
            this.btnActives.Size = new System.Drawing.Size(93, 28);
            this.btnActives.TabIndex = 21;
            this.btnActives.Text = "Actives";
            this.btnActives.UseVisualStyleBackColor = true;
            this.btnActives.Click += new System.EventHandler(this.btnActives_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 145);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 28);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstDoctors
            // 
            this.lstDoctors.FormattingEnabled = true;
            this.lstDoctors.Location = new System.Drawing.Point(440, 83);
            this.lstDoctors.Margin = new System.Windows.Forms.Padding(2);
            this.lstDoctors.Name = "lstDoctors";
            this.lstDoctors.Size = new System.Drawing.Size(222, 303);
            this.lstDoctors.TabIndex = 14;
            this.lstDoctors.Click += new System.EventHandler(this.lstDoctors_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(205, 100);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(113, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(205, 65);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(113, 20);
            this.txtUserName.TabIndex = 13;
            // 
            // DoctorCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifieds);
            this.Controls.Add(this.btnDestory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPassives);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.btnActives);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstDoctors);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "DoctorCrudForm";
            this.Text = "DoctorCrudForm";
            this.Load += new System.EventHandler(this.DoctorCrudForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifieds;
        private System.Windows.Forms.Button btnDestory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPassives;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnActives;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstDoctors;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
    }
}