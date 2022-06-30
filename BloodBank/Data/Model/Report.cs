using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Data.Model
{
    public class Report
    {
        public BloodBag bloodBag { get; set; }
        public DateTime dateTime { get; set; }
        public Employee laborant { get; set; }
        public RHFactor rhFactor { get; set; }
        public BloodType bloodType { get; set; }
        
 

        public override bool Equals(object obj)
        {
            return obj is Report report &&
                   EqualityComparer<BloodBag>.Default.Equals(bloodBag, report.bloodBag);
        }

        public override int GetHashCode()
        {
            return -1826336353 + EqualityComparer<BloodBag>.Default.GetHashCode(bloodBag);
        }

        public override string ToString()
        {
            return bloodBag.Id.ToString();
        }
    }
}
