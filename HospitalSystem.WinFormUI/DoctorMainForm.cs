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
    public partial class DoctorMainForm : Form
    {
        Doctor _authDoctor;
        AppointmentRepository _appRep;

        public DoctorMainForm(Doctor doctor)
        {
            InitializeComponent();
            _authDoctor = doctor;
            _appRep = new AppointmentRepository();
        }

        private void DoctorMainForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _authDoctor.UserName;
            lblName.Text = _authDoctor.DoctorProfile.Name;
            lblSurname.Text = _authDoctor.DoctorProfile.Surname;
            lblEmail.Text = _authDoctor.DoctorProfile.Email;
            lblPhone.Text = _authDoctor.DoctorProfile.Phone;
            lblDepartman.Text = _authDoctor.DoctorProfile.Department.ToString();

            foreach (Appointment item in _authDoctor.Appointments)
            {
                if(item.Patient != null && item.StartDate > DateTime.Now)
                {
                    lstDoctorAppointments.Items.Add(item);
                }
            }

            
        }
    }
}
