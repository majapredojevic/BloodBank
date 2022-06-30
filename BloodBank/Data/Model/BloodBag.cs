using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Data.Model
{
  public  class BloodBag
    {
        public int Id { get; set; }
        public int Capacity { get; set; }

        public override bool Equals(object obj)
        {
            return obj is BloodBag bag &&
                   Id == bag.Id;
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
