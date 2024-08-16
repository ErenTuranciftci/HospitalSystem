using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.ENTITIES.Models
{
    public class DoctorProfile : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Specialization { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? DepartmentID { get; set; }

        //Relational Properties

        public virtual Doctor Doctor { get; set; }
        public virtual Department Department { get; set; }
    }
}
