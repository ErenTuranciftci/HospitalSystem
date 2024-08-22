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

		private void btnAdminLogin_Click(object sender, EventArgs e)
		{
			string username = txtUserName.Text.Trim();
			string password = txtUserPassword.Text.Trim();

			if (username.Length > 0 && password.Length > 0)
			{
				List<Admin> admins = _admRep.Where(x => x.UserName == username && x.Password == password);
				if (admins.Count() > 0)
				{
                    AdminPanelForm adminPanelForm = new AdminPanelForm();
					MessageBox.Show($"Giriş Başarılı", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Hide();
					adminPanelForm.ShowDialog();
				}
				else MessageBox.Show("Kullanıcı Adı veya Parolanız yanlış...\nLütfen yeniden deneyiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else MessageBox.Show("Kullanıcı Adı veya Parola alanları boş geçilemez..\nLütfen yeniden deneyiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void cbxGoster_CheckedChanged(object sender, EventArgs e)
		{
			if (cbxGoster.CheckState == CheckState.Checked)
			{
				txtUserPassword.UseSystemPasswordChar = true;

			}
			else if (cbxGoster.CheckState == CheckState.Unchecked)
			{
				txtUserPassword.UseSystemPasswordChar = false;
			}
		}
	}
}
