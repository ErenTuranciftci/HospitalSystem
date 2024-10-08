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
    public partial class DoctorCrudForm : Form
    {

        DoctorRepository _docRep;
        public DoctorCrudForm()
        {
            InitializeComponent();
            _docRep = new DoctorRepository();
        }

        private void DoctorCrudForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            lstDoctors.DataSource = _docRep.GetAll();
            lstDoctors.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
            {
                Doctor d = new Doctor()
                {
                    UserName = txtUserName.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                };
                _docRep.Add(d);
                Listele();
            } else MessageBox.Show("Username and Password fields cannot be left blank.\r\nThe transaction could not be completed");
        }

        Doctor _selected;

        private void lstDoctors_Click(object sender, EventArgs e)
        {
            if(lstDoctors.SelectedItem != null) _selected = lstDoctors.SelectedItem as Doctor;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                _selected.UserName = txtUserName.Text.Trim();
                _selected.Password = txtPassword.Text.Trim();
                _docRep.Update(_selected);
                _selected = null;
                Listele();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                _docRep.Delete(_selected);
                _selected = null;
                Listele();
            }
        }

        private void btnDestory_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                _docRep.Destroy(_selected);
                _selected = null;
                Listele();
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            lstDoctors.DataSource = _docRep.GetAll();
        }

        private void btnActives_Click(object sender, EventArgs e)
        {
            lstDoctors.DataSource = _docRep.GetActives();
        }

        private void btnPassives_Click(object sender, EventArgs e)
        {
            lstDoctors.DataSource = _docRep.GetPassives();
        }

        private void btnModifieds_Click(object sender, EventArgs e)
        {
            lstDoctors.DataSource = _docRep.GetModifieds();
        }

    }
}
