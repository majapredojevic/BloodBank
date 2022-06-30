using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Data.Model;

namespace BloodBank.Data.DataAccess
{
   public  interface IBloodParameter
    {
        List<BloodParameter> GetBloodParameters(string filter);
        void InsertBloodParameter(BloodParameter parameter);
        void UpdateBloodParameter(BloodParameter parameter);
        void DeleteBloodParameterById(int id);
    }
}
