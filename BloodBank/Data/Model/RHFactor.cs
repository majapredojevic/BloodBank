using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Data.Model
{
   public  class RHFactor
    { 
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is RHFactor factor &&
                   Name == factor.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
