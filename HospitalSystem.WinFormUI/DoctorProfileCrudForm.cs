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
    public partial class DoctorProfileCrudForm : Form
    {
        DoctorRepository _docRep;
        DoctorProfileRepository _docProRep;
        DepartmentRepository _depRep;

        public DoctorProfileCrudForm()
        {
            InitializeComponent();
            _docRep = new DoctorRepository();
            _depRep = new DepartmentRepository();
            _docProRep = new DoctorProfileRepository();
        }

        private void DoctorProfileCrudForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            lstDoctorProfiles.DataSource = _docProRep.GetActives();
            cmbDepartments.DataSource = _depRep.GetActives();
            cmbDoctors.DataSource = _docRep.GetActives();

            lstDoctorProfiles.SelectedIndex = -1;
            cmbDepartments.SelectedIndex = -1;
            cmbDoctors.SelectedIndex = -1;
        }

        Doctor _selectedDoc;
        Department _selectedDep;
        DoctorProfile _selectedDocPro;

        private void cmbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartments.SelectedItem != null) _selectedDep = cmbDepartments.SelectedItem as Department;
        }

        private void cmbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoctors.SelectedItem != null) _selectedDoc = cmbDoctors.SelectedItem as Doctor;
        }

        private void lstDoctorProfiles_Click(object sender, EventArgs e)
        {
            if (lstDoctorProfiles.SelectedItem != null) _selectedDocPro = lstDoctorProfiles.SelectedItem as DoctorProfile;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_selectedDep == null || _selectedDoc == null)
            {
                MessageBox.Show("Lütfen bir departman ve doktor seçin.");
                return;
            }
            DoctorProfile dP = new DoctorProfile()
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Department = _selectedDep,
                Doctor = _selectedDoc,
                DepartmentID = _selectedDep.ID
            };
            _docProRep.Add(dP);
            _selectedDoc = null;
            _selectedDep = null;
            Listele();
        }        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedDocPro != null && _selectedDep != null)
            {
                _selectedDocPro.Name = txtName.Text;
                _selectedDocPro.Email = txtEmail.Text;
                _selectedDocPro.Email = txtEmail.Text;
                _selectedDocPro.Phone = txtPhone.Text;
                _selectedDocPro.Department = _selectedDep;
                _selectedDocPro.DepartmentID = _selectedDep.ID;

                _docProRep.Update(_selectedDocPro);
                _selectedDocPro = null;
                _selectedDep = null;
                Listele();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedDocPro != null)
            {
                _docProRep.Delete(_selectedDocPro);
                _selectedDocPro = null;
                Listele();
            }
        }

        private void btnDestory_Click(object sender, EventArgs e)
        {
            if (_selectedDocPro != null)
            {
                _docProRep.Destroy(_selectedDocPro);
                _selectedDocPro = null;
                Listele();
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            lstDoctorProfiles.DataSource = _docProRep.GetAll();
        }

        private void btnActives_Click(object sender, EventArgs e)
        {
            lstDoctorProfiles.DataSource = _docProRep.GetActives();
        }

        private void btnPassives_Click(object sender, EventArgs e)
        {
            lstDoctorProfiles.DataSource = _docProRep.GetPassives();
        }

        private void btnModifieds_Click(object sender, EventArgs e)
        {
            lstDoctorProfiles.DataSource = _docProRep.GetModifieds();
        }
                
    }
}
