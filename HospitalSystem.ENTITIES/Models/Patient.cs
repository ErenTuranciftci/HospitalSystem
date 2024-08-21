using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.ENTITIES.Models
{
    public class Patient : BaseUser
    {
        
        //Relational Properties

        public virtual PatientProfile PatientProfile { get; set; }
        public virtual List<Appointment> Appointments { get; set; }

        //Methods

        public override string ToString()
        {
            return $"{UserName} {Password}";
        }
    }
}
