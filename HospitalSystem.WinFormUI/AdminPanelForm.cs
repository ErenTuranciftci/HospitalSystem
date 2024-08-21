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
            PatientCrudForm form = new PatientCrudForm();
            form.ShowDialog();
        }

        private void btnDoctorCrud_Click(object sender, EventArgs e)
        {
            DoctorCrudForm form = new DoctorCrudForm();
            form.ShowDialog();
        }

        private void btnPatientProfileCrud_Click(object sender, EventArgs e)
        {
            PatientProfileCrudForm form = new PatientProfileCrudForm();
            form.ShowDialog();
        }

        private void btnDoctorProfileCrud_Click(object sender, EventArgs e)
        {
            DoctorProfileCrudForm form = new DoctorProfileCrudForm();
            form.ShowDialog();
        }

        private void btnAppointmentCrud_Click(object sender, EventArgs e)
        {
            AppointmentCrudForm form = new AppointmentCrudForm();
            form.ShowDialog();
        }

        private void btnDepartmentCrud_Click(object sender, EventArgs e)
        {
            DepartmentCrudForm form = new DepartmentCrudForm();
            form.ShowDialog();
        }

        private void btnAdminCrud_Click(object sender, EventArgs e)
        {
            AdminCrudForm form = new AdminCrudForm();
            form.ShowDialog();
        }
    }
}
