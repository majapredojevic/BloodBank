using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Data.Model
{
    public class Virus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReferenceValue { get; set; }
        public string Unit { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Virus virus &&
                   Id == virus.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
