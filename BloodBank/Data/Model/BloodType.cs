using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Data.Model
{
    public class BloodType
    { public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is BloodType type &&
                   Name == type.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
