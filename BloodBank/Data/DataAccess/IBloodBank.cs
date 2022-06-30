using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Data.Model;

namespace BloodBank.Data.DataAccess
{
    public interface IBloodBank
    {
        List<Model.BloodBank> GetBloodBank();


    }
}
