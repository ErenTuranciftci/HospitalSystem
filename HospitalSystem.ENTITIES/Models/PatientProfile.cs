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
        public string TCKNo { get; set; }      
        public string Phone {  get; set; }
        public string Email { get; set; }                  

        //Relational Properties

        public virtual Patient Patient { get; set; }

        //Methods

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
