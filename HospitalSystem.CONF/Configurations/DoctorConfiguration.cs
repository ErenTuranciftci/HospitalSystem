using HospitalSystem.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.CONF.Configurations
{
    public class DoctorConfiguration : BaseConfiguration<Doctor>
    {
        public DoctorConfiguration()
        {
            HasOptional(x => x.DoctorProfile).WithRequired(x => x.Doctor);
        }
    }
}
