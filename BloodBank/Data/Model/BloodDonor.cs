using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Data.Model
{
    public class BloodDonor
    { public Person Person { get; set; }
        public string FathersName { get; set; }
            public RHFactor RHFactor { get; set; }
            public BloodType BloodType { get; set; }
        public int NumberOfDonations { get; set; }

        public override bool Equals(object obj)
        {
            return obj is BloodDonor donor &&
                   EqualityComparer<Person>.Default.Equals(Person, donor.Person);
        }

        public override int GetHashCode()
        {
            return 2099240096 + EqualityComparer<Person>.Default.GetHashCode(Person);
        }

        public override string ToString()
        { if (FathersName.Equals(string.Empty))
                return Person.FirstName + " " + Person.LastName;
       
            return Person.FirstName +" (" + FathersName + ") " + Person.LastName;
        }
    }
}
