using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.ENTITIES.Models
{
    public class Admin : BaseUser
    {

		public override string ToString()
		{
			return $" {UserName} {Password}";
		}
	}
}
