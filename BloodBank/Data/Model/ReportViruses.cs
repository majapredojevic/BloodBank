using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Data.Model
{
  public class ReportViruses
    { 
       public  Virus virus { get; set; }
       public  Report report { get; set; }
       public Decimal value { get; set; }

      

        public override bool Equals(object obj)
        {
            return obj is ReportViruses viruses &&
                   EqualityComparer<Virus>.Default.Equals(virus, viruses.virus) &&
                   EqualityComparer<Report>.Default.Equals(report, viruses.report);
        }

        public override int GetHashCode()
        {
            int hashCode = -713322503;
            hashCode = hashCode * -1521134295 + EqualityComparer<Virus>.Default.GetHashCode(virus);
            hashCode = hashCode * -1521134295 + EqualityComparer<Report>.Default.GetHashCode(report);
            return hashCode;
        }

        public override string ToString()
        {
            return virus.Name + value.ToString();
        }
    }
}
