using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BloodBank.Data.Model
{
    public class BloodDonation
    {
        public int Id { get; set; }
       public  BloodDonor Donor { get; set; }
        public DateTime DateOfDonation { get; set; }
        public int Hemoglobin { get; set; }
        public string BloodPressure { get; set; }
        public int Pulse { get; set; }
        public string HealthCondition { get; set; }
       public  Employee Doctor { get; set; }
        public Office Office { get; set; }
        public BloodBag BloodBag { get; set; }
        

        public override bool Equals(object obj)
        {
            return obj is BloodDonation donation &&
                   Id == donation.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
