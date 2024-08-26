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
    public partial class PatientMainForm : Form
    {
        Patient _authPatient;

        public PatientMainForm(Patient patient)
        {
            InitializeComponent();
            _authPatient = patient;
        }

        void UpdatePatientInfos()
        {
            if (_authPatient != null)
            {
                lblUserName.Text = _authPatient.UserName;
                if(_authPatient.PatientProfile != null)
                {
                    if (_authPatient.PatientProfile.Name != null) lblName.Text = _authPatient.PatientProfile.Name;
                    else lblName.Text = "-";
                    if (_authPatient.PatientProfile.Surname != null) lblSurname.Text = _authPatient.PatientProfile.Surname;
                    else lblSurname.Text = "-";
                    if (_authPatient.PatientProfile.TCKNo != null) lblTCKNo.Text = _authPatient.PatientProfile.TCKNo;
                    else lblTCKNo.Text = "-";
                    if(_authPatient.PatientProfile.Phone != null) lblPhone.Text = _authPatient.PatientProfile.Phone;
                    else lblPhone.Text = "-";
                    if(_authPatient.PatientProfile.Email != null) lblEmail.Text = _authPatient.PatientProfile.Email;
                    else lblEmail.Text = "-";
                }
                else
                {
                    lblName.Text = lblSurname.Text = lblTCKNo.Text = lblPhone.Text = lblEmail.Text = "-";
                }
            }
            else throw new Exception("The value of the _authPatient variable in PatientMainForm is null. Authentication failed.");

        }

        private void PatientMainForm_Load(object sender, EventArgs e)
        {
           UpdatePatientInfos();
        }

        private void btnPatientAppointment_Click(object sender, EventArgs e)
        {
            Hide();
            PatientAppointmentForm patientAppointmentForm = new PatientAppointmentForm(_authPatient);
            patientAppointmentForm.ShowDialog();
            UpdatePatientInfos();
            Show();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Hide();
            PatientUpdateProfileForm patientUpdateProfileForm = new PatientUpdateProfileForm(_authPatient);
            patientUpdateProfileForm.ShowDialog();
            UpdatePatientInfos();
            Show();
        }
    }
}
