using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Data.Model;

namespace BloodBank.Data.DataAccess
{
   public  interface IEmployee
    {
        List<Employee> GetDoctors();
        List<Employee> GetLaborants();
        int GetDoctorByName(string Name);
        int GetLaborantByName(string Name);
    }
}
