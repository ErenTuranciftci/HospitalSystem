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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void btnPatientCrud_Click(object sender, EventArgs e)
        {
            Hide();
            PatientCrudForm patientCrudForm = new PatientCrudForm();
            patientCrudForm.ShowDialog();
            Show();
        }

        private void btnDoctorCrud_Click(object sender, EventArgs e)
        {
            Hide();
            DoctorCrudForm doctorCrudForm = new DoctorCrudForm();
            doctorCrudForm.ShowDialog();
            Show();
        }

        private void btnPatientProfileCrud_Click(object sender, EventArgs e)
        {
            Hide();
            PatientProfileCrudForm patientProfileCrudForm = new PatientProfileCrudForm();
            patientProfileCrudForm.ShowDialog();
            Show();
        }

        private void btnDoctorProfileCrud_Click(object sender, EventArgs e)
        {
            Hide();
            DoctorProfileCrudForm doctorProfileCrudForm = new DoctorProfileCrudForm();
            doctorProfileCrudForm.ShowDialog();
            Show();
        }

        private void btnAppointmentCrud_Click(object sender, EventArgs e)
        {
            Hide();
            AppointmentCrudForm appointmentCrudForm = new AppointmentCrudForm();
            appointmentCrudForm.ShowDialog();
            Show();
        }

        private void btnDepartmentCrud_Click(object sender, EventArgs e)
        {
            Hide();
            DepartmentCrudForm departmentCrudForm = new DepartmentCrudForm();
            departmentCrudForm.ShowDialog();
            Show();
        }

        private void btnAdminCrud_Click(object sender, EventArgs e)
        {
            Hide();
            AdminCrudForm adminCrudForm = new AdminCrudForm();
            adminCrudForm.ShowDialog();
            Show();
        }
    }
}
