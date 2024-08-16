using HospitalSystem.DAL.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.BLL.DesignPatterns.SingletonPattern
{
    public class DBTool
    {

        DBTool() { }

        static HospitalContext _dbInstance;

        public static HospitalContext DbInstance
        {
            get
            {
                if (_dbInstance == null) _dbInstance = new HospitalContext();
                return _dbInstance;
            }
        }
    }
}
