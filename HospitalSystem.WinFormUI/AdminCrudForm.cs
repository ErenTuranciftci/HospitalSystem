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
    public partial class AdminCrudForm : Form
    {
        AdminRepository _admRep;
        public AdminCrudForm()
        {
            InitializeComponent();
            _admRep = new AdminRepository();
        }

        private void AdminCrudForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            lstAdmins.DataSource = _admRep.GetAll();
            lstAdmins.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Admin a = new Admin()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            };
            _admRep.Add(a);
            Listele();
        }

        Admin _selected;

        private void lstAdmins_Click(object sender, EventArgs e)
        {
            if (lstAdmins.SelectedItem != null) _selected = lstAdmins.SelectedItem as Admin;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                _selected.UserName = txtUserName.Text;
                _selected.Password = txtPassword.Text;
                _admRep.Update(_selected);
                _selected = null;
                Listele();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                _admRep.Delete(_selected);
                _selected = null;
                Listele();
            }
        }

        private void btnDestory_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                _admRep.Destroy(_selected);
                _selected = null;
                Listele();
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            lstAdmins.DataSource = _admRep.GetAll();
        }

        private void btnActives_Click(object sender, EventArgs e)
        {
            lstAdmins.DataSource = _admRep.GetActives();
        }

        private void btnPassives_Click(object sender, EventArgs e)
        {
            lstAdmins.DataSource = _admRep.GetPassives();
        }

        private void btnModifieds_Click(object sender, EventArgs e)
        {
            lstAdmins.DataSource = _admRep.GetModifieds();
        }
    }
}
