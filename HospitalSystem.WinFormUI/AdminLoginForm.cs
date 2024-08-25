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
	public partial class AdminLoginForm : Form
	{
		AdminRepository _admRep;
		public AdminLoginForm()
		{
			InitializeComponent();
			_admRep = new AdminRepository();
		}
		// sifre işlemleri basarili ise AdminPanelForm'a yönlendirilme yapılıyor.
		private void btnAdminLogin_Click(object sender, EventArgs e)
		{
			string username = txtUserName.Text.Trim();
			string password = txtUserPassword.Text.Trim();

			if (username.Length > 0 && password.Length > 0)
			{
				List<Admin> admins = _admRep.Where(x => x.UserName == username && x.Password == password && x.DataStatus != ENTITIES.Enums.DataStatus.Deleted);
				if (admins.Count() > 0)
				{
                    MessageBox.Show($"Login successful", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Hide();
                    txtUserName.Text = txtUserPassword.Text = string.Empty;
                    AdminPanelForm adminPanelForm = new AdminPanelForm();
                    adminPanelForm.ShowDialog();
					Show();
				}
				else MessageBox.Show("Your Username or Password is incorrect.\r\nPlease try again...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else MessageBox.Show("Username or Password fields cannot be empty.\r\nPlease try again...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void cbxGoster_CheckedChanged(object sender, EventArgs e)
		{
			if (cbxGoster.CheckState == CheckState.Checked)
			{
				txtUserPassword.UseSystemPasswordChar = true;

			}
			else txtUserPassword.UseSystemPasswordChar = false;
		}
	}
}
