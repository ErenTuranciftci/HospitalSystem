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
		Admin _admin;
		AdminRepository _admRep;
		public AdminLoginForm()
		{
			InitializeComponent();
			_admin = (new AdminRepository()).Find(1);
		}

		private void btnAdminLogin_Click(object sender, EventArgs e)
		{

			if (txtUserName.Text == _admin.UserName && txtUserPassword.Text == _admin.Password)
			{

				AdminPanelForm adminPanelForm = new AdminPanelForm();
				MessageBox.Show($"Giriş Başarılı", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Hide();
				adminPanelForm.ShowDialog();
			}
			else
			{
				MessageBox.Show("Kullanıcı Adı veya Paralanız yanlış...\nLütfen yeniden deneyiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
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
