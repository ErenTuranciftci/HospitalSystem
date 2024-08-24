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
	public partial class PatientLoginFom : Form
	{
		PatientRepository _patRep;
		public PatientLoginFom()
		{
			InitializeComponent();
			_patRep = new PatientRepository();
		}

		// sifre işlemleri basarili ise PatientCrudForm'a yönlendirilme yapılıyor.
		private void btnPatientLogin_Click(object sender, EventArgs e)
		{
			string username = txtUserName.Text;
			string password = txtUserPassword.Text;

			if (username.Length > 0 && password.Length > 0)
			{
				List<Patient> patients = _patRep.Where(x => x.UserName == username && x.Password == password);

				if (patients.Count > 0)
				{
					Patient patient = patients[0];
					PatientMainForm patientCrudForm = new PatientMainForm(patient);
					MessageBox.Show($"Giriş Başarılı", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Hide();
					patientCrudForm.Show();
				}
				else
				{
					MessageBox.Show("Kullanıcı Adı veya Parolanız yanlış...\nLütfen yeniden deneyiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
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
