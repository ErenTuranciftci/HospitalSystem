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
	public partial class SystemLogin : Form
	{
		public SystemLogin()
		{
			InitializeComponent();
		}

		private void btnAdminLogin_Click(object sender, EventArgs e)
		{
			AdminLoginForm adminLoginForm = new AdminLoginForm();
			this.Hide();
			adminLoginForm.ShowDialog();
		}
	}
}
