using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Data.Model;

namespace BloodBank.Data.DataAccess
{
   public  interface IBloodDonor
    {
        List<BloodDonor> GetBloodDonors(string filter);
        void InsertBloodDonor(BloodDonor donor);
        void UpdateBloodDonor(BloodDonor donor);
        void DeleteBloodDonorById(int Id);
        int CheckIfAddressExist(string state, string city, string postalCode, string street, string streetNumber);
        int CheckNumberOfAddressReference(int IdAddress);
        

    }
}
