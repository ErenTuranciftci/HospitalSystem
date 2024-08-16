using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.ENTITIES.Models
{
    public class Department : BaseEntity
    {
        public string DepartmanName { get; set; }
        public string Description { get; set; }

        //Relational Properties

        public virtual List<DoctorProfile> DoctorProfiles { get; set; }
    }
}
