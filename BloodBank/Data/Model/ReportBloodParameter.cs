using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Data.Model
{
    public class ReportBloodParameter
    {
        public BloodParameter bloodParameter { get; set; }
        public Report report { get; set; }
        public Decimal value { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ReportBloodParameter parameter &&
                   EqualityComparer<BloodParameter>.Default.Equals(bloodParameter, parameter.bloodParameter) &&
                   EqualityComparer<Report>.Default.Equals(report, parameter.report);
        }

        public override int GetHashCode()
        {
            int hashCode = 817148801;
            hashCode = hashCode * -1521134295 + EqualityComparer<BloodParameter>.Default.GetHashCode(bloodParameter);
            hashCode = hashCode * -1521134295 + EqualityComparer<Report>.Default.GetHashCode(report);
            return hashCode;
        }

        public override string ToString()
        {
            return bloodParameter.Name + value.ToString();
        }
    }
}
