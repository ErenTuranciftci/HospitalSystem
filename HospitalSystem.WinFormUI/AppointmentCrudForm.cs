using HospitalSystem.BLL.DesignPatterns.GenericRepository.ConcReps;
using HospitalSystem.ENTITIES.Enums;
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
    public partial class AppointmentCrudForm : Form
    {
        DoctorRepository _docRep;
        AppointmentRepository _appRep;
        Appointment _selectedAppointment;

        public AppointmentCrudForm()
        {
            InitializeComponent();
            _docRep = new DoctorRepository();
            _appRep = new AppointmentRepository();
        }


        List<DateTime> GenerateDates(int dayCount = 30)  //dayCount parametresi default olarak 30 günlük dikkate alarak DateTime tipinde liste üretir.
        {
            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < dayCount; i++)
            {
                if (i == 0 && DateTime.Now > DateTime.Parse("16:00")) continue;  // Randevular hastanede 09:00-17:00 arasında birer saatlik dilimler şeklindedir. Bu yüzden Saat 16.00 yı geçmişse bugün randevu üretilemez. 
                DateTime dateTmp = DateTime.Now.Date.AddDays(i);
                if (dateTmp.DayOfWeek != DayOfWeek.Saturday && dateTmp.DayOfWeek != DayOfWeek.Sunday) dates.Add(dateTmp); //Cumartesi ve Pazar günleri de randevu alınamaz.
            }
            return dates;
        }

        void SetControls ()
        {
            cmbDates.DataSource = GenerateDates();
            cmbDoctors.DataSource = _docRep.GetAll();
            cmbDoctors.DisplayMember = "UserName";
            lstAppointments.DisplayMember = "StartDate";
            UpdateListbox();
        }

        List<Appointment> ListAppointments(DateTime dateTmp, Doctor doctorTmp)
        {
            DateTime startDateTmp = dateTmp.AddHours(9); // Saat 09:00 randevuya başlama
            DateTime endDateTmp = dateTmp.AddHours(17);  // Saat 17:00 randevuya sonlandırma
            return _appRep.Where(x => startDateTmp <= x.StartDate && x.StartDate < endDateTmp && x.DoctorID == doctorTmp.ID && x.DataStatus != DataStatus.Deleted);
        }

        void UpdateListbox()
        {
            if (cmbDates.SelectedItem != null && cmbDoctors.SelectedItem != null)
            {
                DateTime dateTmp = (cmbDates.SelectedItem as DateTime?).Value;
                Doctor doctorTmp = cmbDoctors.SelectedItem as Doctor;
                lstAppointments.DataSource = ListAppointments(dateTmp.Date, doctorTmp);
                lstAppointments.SelectedIndex = -1;
            }
        }

        private void AppointmentCrudForm_Load(object sender, EventArgs e)
        {
            SetControls();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbDates.SelectedItem != null && cmbDoctors.SelectedItem != null)
            {
                DateTime dateTmp = (cmbDates.SelectedItem as DateTime?).Value;
                Doctor doctorTmp = cmbDoctors.SelectedItem as Doctor;
                List<Appointment> res = ListAppointments(dateTmp, doctorTmp);

                if (res.Count > 0) MessageBox.Show("Seçilen doktorun ilgili tarihte zaten randevuları var.\r\nBu sebepten ilgili tarih için randevular oluşturulamadı.");
                else
                {
                    for (int i = 9; i < 17; i++)
                    {
                        if (dateTmp.AddHours(i) > DateTime.Now) //Randevu saati şimdiki zamandan önce olamaz.
                        {
                            Appointment app = new Appointment();
                            app.StartDate = dateTmp.AddHours(i);
                            app.DoctorID = doctorTmp.ID;
                            _appRep.Add(app);
                        }
                    }
                    MessageBox.Show("Seçilen doktor için ilgili tarihe randevular başarıyla oluşturuldu.");
                }
                UpdateListbox();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if(cmbDates.SelectedItem != null && cmbDoctors.SelectedItem != null)
            {
                DateTime dateTmp = (cmbDates.SelectedItem as DateTime?).Value;
                Doctor doctorTmp = cmbDoctors.SelectedItem as Doctor;
                DateTime startDateTmp = dateTmp.AddHours(9); // Saat 09:00 randevuya başlama
                DateTime endDateTmp = dateTmp.AddHours(17);  // Saat 17:00 randevuya sonlandırma
                List<Appointment> res = _appRep.Where(x => startDateTmp <= x.StartDate && x.StartDate < endDateTmp && x.DoctorID == doctorTmp.ID);
                if (res.Count == 0) MessageBox.Show("Bu tarihte randevu bulunamadı.");
                lstAppointments.DataSource = res;
                lstAppointments.SelectedIndex = -1;
            }
        }

        private void lstAppointments_Click(object sender, EventArgs e)
        {
            if (lstAppointments.SelectedItem != null) _selectedAppointment = lstAppointments.SelectedItem as Appointment;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedAppointment != null && cmbDates.SelectedItem != null && cmbDoctors.SelectedItem != null) 
            {
                DateTime dateTmp = (cmbDates.SelectedItem as DateTime?).Value.Date + _selectedAppointment.StartDate.TimeOfDay;
                Doctor doctorTmp = cmbDoctors.SelectedItem as Doctor;
                List<Appointment> res = _appRep.Where(x => x.StartDate == dateTmp && x.DoctorID == doctorTmp.ID);
                if (res.Count > 0)
                {
                    MessageBox.Show("Doktorun ilgili tarihte randevusu bulunmaktadır. Bu yüzden randevu güncellenemedi.");
                    return;
                }
                _selectedAppointment.StartDate = dateTmp;
                _selectedAppointment.DoctorID = doctorTmp.ID;
                _appRep.Update(_selectedAppointment);
                _selectedAppointment = null;
                UpdateListbox();
            } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedAppointment != null)
            {
                _appRep.Delete(_selectedAppointment);
                _selectedAppointment = null;
                UpdateListbox();

            }
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            if (_selectedAppointment != null) 
            {
                _appRep.Destroy(_selectedAppointment);
                _selectedAppointment = null;
                UpdateListboxPassivesAndModifieds(DataStatus.Deleted);
            }
        }

        private void btnActives_Click(object sender, EventArgs e)
        {
            UpdateListbox();
        }
        private void UpdateListboxPassivesAndModifieds(DataStatus dataStatus)
        {
            if (cmbDates.SelectedItem != null && cmbDoctors.SelectedItem != null)
            {
                DateTime dateTmp = (cmbDates.SelectedItem as DateTime?).Value;
                Doctor doctorTmp = cmbDoctors.SelectedItem as Doctor;
                DateTime startDateTmp = dateTmp.AddHours(9); // Saat 09:00 randevuya başlama
                DateTime endDateTmp = dateTmp.AddHours(17);  // Saat 17:00 randevuya sonlandırma
                List<Appointment> res = _appRep.Where(x => startDateTmp <= x.StartDate && x.StartDate < endDateTmp && x.DoctorID == doctorTmp.ID && x.DataStatus == dataStatus);
                lstAppointments.DataSource = res;
                lstAppointments.SelectedIndex = -1;
            }
        }

        private void btnPassives_Click(object sender, EventArgs e)
        {
            UpdateListboxPassivesAndModifieds(DataStatus.Deleted);
        }

        private void btnModifieds_Click(object sender, EventArgs e)
        {
            UpdateListboxPassivesAndModifieds(DataStatus.Modified);
        }

        private void cmbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListbox();
        }
    }
}
