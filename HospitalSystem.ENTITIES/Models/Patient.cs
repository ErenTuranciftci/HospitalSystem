using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.ENTITIES.Models
{
    public class Patient : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //Relational Properties

        public virtual PatientProfile PatientProfile { get; set; }
        public virtual List<Appointment> Appointments { get; set; }
    }
}
