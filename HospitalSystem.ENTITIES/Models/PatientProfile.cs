using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.ENTITIES.Models
{
    public class PatientProfile : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        //Relational Properties

        public virtual Patient Patient { get; set; }
    }
}
