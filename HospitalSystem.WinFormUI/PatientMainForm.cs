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
            else throw new Exception("PatientMainForm'daki _authPatient değişkeninin değeri null geldi. Authentication işlemi başarısız.");

        }

        private void PatientMainForm_Load(object sender, EventArgs e)
        {
           UpdatePatientInfos();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdatePatientInfos();
        }

        private void btnPatientAppointment_Click(object sender, EventArgs e)
        {
            PatientAppointmentForm frm = new PatientAppointmentForm(_authPatient);
            frm.ShowDialog();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            PatientUpdateProfileForm frm = new PatientUpdateProfileForm(_authPatient);
            frm.ShowDialog();
        }
    }
}
