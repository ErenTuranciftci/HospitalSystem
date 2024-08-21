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
    public partial class PatientProfileCrudForm : Form
    {
        PatientProfileRepository _patProRep;
        PatientRepository _patRep;
        public PatientProfileCrudForm()
        {
            InitializeComponent();
            _patProRep = new PatientProfileRepository();
            _patRep = new PatientRepository();
        }

        private void PatientProfileCrudForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            lstPatientProfiles.DataSource = _patProRep.GetActives();
            cmbPatients.DataSource = _patRep.GetActives();

            lstPatientProfiles.SelectedIndex = -1;
            cmbPatients.SelectedIndex = -1;            
        }

        PatientProfile _selectedPatPro;
        Patient _selectedPat;

        private void lstPatientProfiles_Click(object sender, EventArgs e)
        {
            if (lstPatientProfiles.SelectedItem != null) _selectedPatPro = lstPatientProfiles.SelectedItem as PatientProfile;
        }

        private void cmbPatients_Click(object sender, EventArgs e)
        {
            if (cmbPatients.SelectedItem != null) _selectedPat = cmbPatients.SelectedItem as Patient;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_selectedPat == null)
            {
                MessageBox.Show("Lütfen bir doktor seçin.");
                return;
            }
            PatientProfile dP = new PatientProfile()
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                TCKNo = txtTCKNo.Text,
                Patient = _selectedPat                
            };
            _patProRep.Add(dP);
            _selectedPat = null;            
            Listele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedPatPro != null && _selectedPat != null)
            {
                _selectedPatPro.Name = txtName.Text;
                _selectedPatPro.Email = txtEmail.Text;
                _selectedPatPro.Email = txtEmail.Text;
                _selectedPatPro.Phone = txtPhone.Text;
                _selectedPatPro.Patient = _selectedPat;                

                _patProRep.Update(_selectedPatPro);
                _selectedPatPro = null;
                _selectedPat = null;
                Listele();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedPatPro != null)
            {
                _patProRep.Delete(_selectedPatPro);
                _selectedPatPro = null;
                Listele();
            }
        }

        private void btnDestory_Click(object sender, EventArgs e)
        {
            if (_selectedPatPro != null)
            {
                _patProRep.Destroy(_selectedPatPro);
                _selectedPatPro = null;
                Listele();
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            lstPatientProfiles.DataSource = _patProRep.GetAll();
        }

        private void btnActives_Click(object sender, EventArgs e)
        {
            lstPatientProfiles.DataSource = _patProRep.GetActives();
        }

        private void btnPassives_Click(object sender, EventArgs e)
        {
            lstPatientProfiles.DataSource = _patProRep.GetPassives();
        }

        private void btnModifieds_Click(object sender, EventArgs e)
        {
            lstPatientProfiles.DataSource = _patProRep.GetModifieds();
        }
    }
}
