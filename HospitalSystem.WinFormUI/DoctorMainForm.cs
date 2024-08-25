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
            if (_authDoctor.DoctorProfile != null) 
            {
                if (_authDoctor.DoctorProfile.Name != null) lblName.Text = _authDoctor.DoctorProfile.Name;
                else lblName.Text = "-";
                if (_authDoctor.DoctorProfile.Surname != null) lblSurname.Text = _authDoctor.DoctorProfile.Surname;
                else lblSurname.Text = "-";
                if (_authDoctor.DoctorProfile.Email != null) lblEmail.Text = _authDoctor.DoctorProfile.Email;
                else lblEmail.Text = "-";
                if (_authDoctor.DoctorProfile.Phone != null) lblPhone.Text = _authDoctor.DoctorProfile.Phone;
                else lblPhone.Text = "-";
                if (_authDoctor.DoctorProfile.Department != null) lblDepartment.Text = _authDoctor.DoctorProfile.Department.ToString();
                else lblDepartment.Text = "-";
            }
            else
            {
                lblName.Text = lblSurname.Text = lblEmail.Text = lblPhone.Text = lblDepartment.Text = "-";
            }

            lstDoctorAppointments.DataSource = _authDoctor.Appointments.Where(x=>x.StartDate > DateTime.Now).ToList();            
        }
    }
}
