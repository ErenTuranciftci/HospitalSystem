using HospitalSystem.BLL.DesignPatterns.GenericRepository.ConcReps;
using HospitalSystem.ENTITIES.Enums;
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
    public partial class PatientAppointmentForm : Form
    {
        Patient _authPatient;
        DoctorRepository _docRep;
        AppointmentRepository _appRep;

        public PatientAppointmentForm(Patient patient)
        {
            InitializeComponent();
            _authPatient = patient;
            _docRep = new DoctorRepository();
            _appRep = new AppointmentRepository();
        }

        void ListCmbDates()
        {
            if (cmbDoctors.SelectedItem != null)
            {
                Doctor dr = cmbDoctors.SelectedItem as Doctor;
                cmbDates.DataSource = _appRep.Where(x => x.PatientID == null && x.DoctorID == dr.ID && x.DataStatus != DataStatus.Deleted && x.StartDate > DateTime.Now).OrderBy(x => x.StartDate).ToList();
                cmbDates.SelectedIndex = -1;
            }
        }

       void ListLstApp()
        {
            if (cmbDoctors.SelectedItem != null)
            {
                Doctor dr = cmbDoctors.SelectedItem as Doctor;
                lstAppointments.DataSource = _appRep.Where(x => x.PatientID == _authPatient.ID && x.DoctorID == dr.ID && x.DataStatus != DataStatus.Deleted && x.StartDate > DateTime.Now).OrderBy(x=>x.StartDate).ToList();
            }
        }

        void SetControls()
        {
            lblPatient.Text = _authPatient.UserName;
            cmbDoctors.DataSource = _docRep.GetActives();
            cmbDoctors.DisplayMember = "UserName";
            cmbDates.DisplayMember = "StartDate";
            lstAppointments.DisplayMember = "StartDate";
            ListCmbDates();
            ListLstApp();
        }

        private void PatientAppointmentForm_Load(object sender, EventArgs e)
        {
           SetControls();
        }


        private void cmbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListLstApp();
            ListCmbDates();
        }

        private void btnMakeAnApp_Click(object sender, EventArgs e)
        {
            if(cmbDates.SelectedItem != null && cmbDoctors.SelectedItem != null)
            {
                Appointment appointment = cmbDates.SelectedItem as Appointment;
                appointment.PatientID = _authPatient.ID;
                _appRep.Update(appointment);
                ListLstApp();
                ListCmbDates();
            }
        }

        private void btnCancelApp_Click(object sender, EventArgs e)
        {
            if(lstAppointments.SelectedItem != null)
            {
                Appointment appointment = lstAppointments.SelectedItem as Appointment;
                appointment.PatientID = null;
                _appRep.Update(appointment);
                ListLstApp();
                ListCmbDates();
            }

        }
    }
}
