using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Data.Model;

namespace BloodBank.Data.DataAccess
{
    public interface IOffice
    {
        List<Office> GetOffices();
        int GetOfficeByName(string name);
    }
}
