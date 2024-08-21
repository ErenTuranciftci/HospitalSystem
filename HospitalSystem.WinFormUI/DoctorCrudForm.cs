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
    public partial class DoctorCrudForm : Form
    {

        DoctorRepositoy _docRep;
        public DoctorCrudForm()
        {
            InitializeComponent();
            _docRep = new DoctorRepositoy();
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
            Doctor d = new Doctor()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
            };
            _docRep.Add(d);
            Listele();
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
                _selected.UserName = txtUserName.Text;
                _selected.Password = txtPassword.Text;
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
