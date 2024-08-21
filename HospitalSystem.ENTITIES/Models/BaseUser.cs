using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.ENTITIES.Models
{
    public abstract class BaseUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
