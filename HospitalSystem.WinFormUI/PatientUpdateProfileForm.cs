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
    public partial class PatientUpdateProfileForm : Form
    {
        Patient _authPatient;
        PatientRepository _patRep;

        public PatientUpdateProfileForm(Patient patient)
        {
            InitializeComponent();
            _authPatient = patient;
            _patRep = new PatientRepository();
        }

        void UpdatePatientInfos()
        {
            if (_authPatient != null)
            {
                if(_authPatient.PatientProfile == null) _authPatient.PatientProfile = new PatientProfile();
                if (txtName.Text.Trim().Length > 0) _authPatient.PatientProfile.Name = txtName.Text.Trim();
                if (txtSurname.Text.Trim().Length > 0) _authPatient.PatientProfile.Surname = txtSurname.Text.Trim();
                if (txtTCKNo.Text.Trim().Length > 0) _authPatient.PatientProfile.TCKNo = txtTCKNo.Text.Trim();
                if (txtPhone.Text.Trim().Length > 0) _authPatient.PatientProfile.Phone = txtPhone.Text.Trim();
                if (txtEmail.Text.Trim().Length>0) _authPatient.PatientProfile.Email = txtEmail.Text.Trim();
                _patRep.Update(_authPatient);
                MessageBox.Show("The data entered into the form was recorded.");
            }
            else throw new Exception("The value of the _authPatient variable in PatientUpdateProfile was null. Authentication failed.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdatePatientInfos();
        }
    }
}
