﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HospitalSystem.ENTITIES.Models
{
    public class Doctor : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //Relational Properties

        public virtual DoctorProfile DoctorProfile { get; set; }
        public virtual List<Appointment> Appointments { get; set; }

        //Methods

        public override string ToString()
        {
            return $"{UserName} {Password}";
        }
    }
}
