namespace HospitalSystem.WinFormUI
{
    partial class DepartmentCrudForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPassives = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnActives = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstDepaments = new System.Windows.Forms.ListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnDestory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifieds
            // 
            this.btnModifieds.Location = new System.Drawing.Point(225, 222);
            this.btnModifieds.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifieds.Name = "btnModifieds";
            this.btnModifieds.Size = new System.Drawing.Size(93, 28);
            this.btnModifieds.TabIndex = 6;
            this.btnModifieds.Text = "Modifieds";
            this.btnModifieds.UseVisualStyleBackColor = true;
            this.btnModifieds.Click += new System.EventHandler(this.btnModifieds_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(87, 190);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPassives
            // 
            this.btnPassives.Location = new System.Drawing.Point(225, 190);
            this.btnPassives.Margin = new System.Windows.Forms.Padding(2);
            this.btnPassives.Name = "btnPassives";
            this.btnPassives.Size = new System.Drawing.Size(93, 28);
            this.btnPassives.TabIndex = 8;
            this.btnPassives.Text = "Passives";
            this.btnPassives.UseVisualStyleBackColor = true;
            this.btnPassives.Click += new System.EventHandler(this.btnPassives_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 158);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 28);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnActives
            // 
            this.btnActives.Location = new System.Drawing.Point(225, 158);
            this.btnActives.Margin = new System.Windows.Forms.Padding(2);
            this.btnActives.Name = "btnActives";
            this.btnActives.Size = new System.Drawing.Size(93, 28);
            this.btnActives.TabIndex = 10;
            this.btnActives.Text = "Actives";
            this.btnActives.UseVisualStyleBackColor = true;
            this.btnActives.Click += new System.EventHandler(this.btnActives_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(87, 124);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 28);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstDepaments
            // 
            this.lstDepaments.FormattingEnabled = true;
            this.lstDepaments.Location = new System.Drawing.Point(388, 62);
            this.lstDepaments.Margin = new System.Windows.Forms.Padding(2);
            this.lstDepaments.Name = "lstDepaments";
            this.lstDepaments.Size = new System.Drawing.Size(222, 303);
            this.lstDepaments.TabIndex = 5;
            this.lstDepaments.Click += new System.EventHandler(this.lstDepaments_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(153, 79);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(113, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(113, 20);
            this.txtName.TabIndex = 4;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(225, 124);
            this.btnGetAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(93, 28);
            this.btnGetAll.TabIndex = 10;
            this.btnGetAll.Text = "All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnDestory
            // 
            this.btnDestory.Location = new System.Drawing.Point(87, 222);
            this.btnDestory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDestory.Name = "btnDestory";
            this.btnDestory.Size = new System.Drawing.Size(93, 28);
            this.btnDestory.TabIndex = 7;
            this.btnDestory.Text = "Destroy";
            this.btnDestory.UseVisualStyleBackColor = true;
            this.btnDestory.Click += new System.EventHandler(this.btnDestory_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "DepartmentName";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepartmentCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifieds);
            this.Controls.Add(this.btnDestory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPassives);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.btnActives);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstDepaments);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Name = "DepartmentCrudForm";
            this.Text = "DepartmentCrudForm";
            this.Load += new System.EventHandler(this.DepartmentCrudForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifieds;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPassives;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnActives;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstDepaments;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnDestory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

