using HospitalSystem.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.CONF.Configurations
{
    public class PatientConfiguration : BaseConfiguration<Patient>
    {
        public PatientConfiguration()
        {
            HasOptional(x => x.PatientProfile).WithRequired(x => x.Patient);
        }
    }
}
