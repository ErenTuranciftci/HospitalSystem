using HospitalSystem.BLL.DesignPatterns.GenericRepository.ConcReps;
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
    public partial class PatientCrudForm : Form
    {
        PatientRepository _patRep;
        public PatientCrudForm()
        {
            InitializeComponent();
            _patRep = new PatientRepository();
        }

        private void PatientCrudForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            lstPatients.DataSource = _patRep.GetAll();
            lstPatients.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
            {
                Patient p = new Patient()
                {
                    UserName = txtUserName.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                };
                _patRep.Add(p);
                Listele();
            }
            else MessageBox.Show("Username and Password fields cannot be left blank.\r\nThe transaction could not be completed");
        }

        Patient _selected;

        private void lstPatients_Click(object sender, EventArgs e)
        {
            if (lstPatients.SelectedItem != null) _selected = lstPatients.SelectedItem as Patient;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                _selected.UserName = txtUserName.Text.Trim();
                _selected.Password = txtPassword.Text.Trim();
                _patRep.Update(_selected);
                _selected = null;
                Listele();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                _patRep.Delete(_selected);
                _selected = null;
                Listele();
            }
        }

        private void btnDestory_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                _patRep.Destroy(_selected);
                _selected = null;
                Listele();
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            lstPatients.DataSource = _patRep.GetAll();
        }

        private void btnActives_Click(object sender, EventArgs e)
        {
            lstPatients.DataSource = _patRep.GetActives();
        }

        private void btnPassives_Click(object sender, EventArgs e)
        {
            lstPatients.DataSource = _patRep.GetPassives();
        }

        private void btnModifieds_Click(object sender, EventArgs e)
        {
            lstPatients.DataSource = _patRep.GetModifieds();
        }
    }
}
