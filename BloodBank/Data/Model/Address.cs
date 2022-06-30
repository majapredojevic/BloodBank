using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Data.Model
{
   public class Address
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }


    

        public override bool Equals(object obj)
        {
            return obj is Address address &&
                   Id == address.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return Street + " " + StreetNumber + ", " + PostalCode + " " + City + ", "  + State ;
        }
    }
}
