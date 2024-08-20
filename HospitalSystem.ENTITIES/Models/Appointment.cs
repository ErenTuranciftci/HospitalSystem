using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.ENTITIES.Models
{
    public class Appointment : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public string Reason { get; set; }
        public int? DoctorID { get; set; }
        public int? PatientID { get; set; }

        //Relational Properties

        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
