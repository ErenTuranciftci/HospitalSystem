﻿using HospitalSystem.BLL.DesignPatterns.GenericRepository.ConcReps;
using HospitalSystem.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSystem.WinFormUI
{
    public partial class PatientRegisterForm : Form
    {
        Patient _patient;
        PatientProfile _patProfile;
        PatientRepository _patRep;

        public PatientRegisterForm()
        {
            InitializeComponent();
            _patRep = new PatientRepository();
            _patient = new Patient();
            _patProfile = new PatientProfile();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length == 0 || txtPassword.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Username ve Password alanları boş geçilemez.\r\nKayıt işlemi başarısız");
                return;
            }
            else
            {
                _patient.UserName = txtUserName.Text.Trim();
                _patient.Password = txtPassword.Text.Trim();
            }
            if (txtName.Text.Trim().Length > 0) _patProfile.Name = txtName.Text.Trim();
            if(txtSurname.Text.Trim().Length > 0) _patProfile.Surname = txtSurname.Text.Trim();
            if(txtTCKNo.Text.Trim().Length > 0) _patProfile.TCKNo = txtTCKNo.Text.Trim();
            if(txtPhone.Text.Trim().Length > 0) _patProfile.Phone = txtPhone.Text.Trim();
            if(txtEmail.Text.Trim().Length > 0) _patProfile.Email = txtEmail.Text.Trim();
            _patient.PatientProfile = _patProfile;
            _patRep.Add(_patient);
            MessageBox.Show("Kayıt işlemi başarılı!");
        }
    }
}
