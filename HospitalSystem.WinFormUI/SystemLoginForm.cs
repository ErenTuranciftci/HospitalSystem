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
	public partial class SystemLoginForm : Form
	{
		public SystemLoginForm()
		{
			InitializeComponent();
		}

		private void btnAdminLogin_Click(object sender, EventArgs e)
		{
			Hide();
			AdminLoginForm adminLoginForm = new AdminLoginForm();
			adminLoginForm.ShowDialog();
			Show();
		}

		private void btnDoctorLogin_Click(object sender, EventArgs e)
		{
			Hide();
			DoctorLoginForm doctorLoginForm = new DoctorLoginForm();
			doctorLoginForm.ShowDialog();
			Show();
		}

		private void btnPatientLogin_Click(object sender, EventArgs e)
		{
			Hide();
			PatientLoginFom patientLoginFom = new PatientLoginFom();	
			patientLoginFom.ShowDialog();
			Show();
		}
	}
}
