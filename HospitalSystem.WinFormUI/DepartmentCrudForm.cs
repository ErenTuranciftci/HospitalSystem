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
using System.Xml.Linq;

namespace HospitalSystem.WinFormUI
{
    public partial class DepartmentCrudForm : Form
    {

        DepartmentRepository _depRep;
        public DepartmentCrudForm()
        {
            InitializeComponent();
            _depRep = new DepartmentRepository();
        }
        private void DepartmentCrudForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            lstDepaments.DataSource = _depRep.GetAll();
            lstDepaments.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim().Length > 0 && txtDescription.Text.Trim().Length > 0)
            {
                Department d = new Department()
                {
                    DepartmentName = txtName.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                };
                _depRep.Add(d);
                Listele();
            } else MessageBox.Show("DepartmentName and Description fields cannot be left blank.\r\nThe transaction could not be completed");
        }

        Department _selected;

        private void lstDepaments_Click(object sender, EventArgs e)
        {
            if(lstDepaments.SelectedItem !=null) _selected = lstDepaments.SelectedItem as Department;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                _selected.DepartmentName = txtName.Text.Trim();
                _selected.Description = txtDescription.Text.Trim();
                _depRep.Update(_selected);
                _selected = null;
                Listele();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {                
                _depRep.Delete(_selected);
                _selected = null;
                Listele();
            }
        }

        private void btnDestory_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                _depRep.Destroy(_selected);
                _selected = null;
                Listele();
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            lstDepaments.DataSource = _depRep.GetAll();
        }

        private void btnActives_Click(object sender, EventArgs e)
        {
            lstDepaments.DataSource = _depRep.GetActives();
        }

        private void btnPassives_Click(object sender, EventArgs e)
        {
            lstDepaments.DataSource = _depRep.GetPassives();
        }

        private void btnModifieds_Click(object sender, EventArgs e)
        {
            lstDepaments.DataSource = _depRep.GetModifieds();
        }
    }
}
