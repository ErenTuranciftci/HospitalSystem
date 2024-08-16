using HospitalSystem.BLL.DesignPatterns.GenericRepository.EFBaseRep;
using HospitalSystem.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.BLL.DesignPatterns.GenericRepository.ConcReps
{
    public class AppointmentRepository:BaseRepository<Appointment>
    {
        public AppointmentRepository()
        {
            
        }
    }
}
