using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Data.Model
{
    public class Employee
    {
        public Person Person { get; set; }
        public string Title { get; set; }
       public  Decimal Salary { get; set; }
       public  Office Office { get; set; }


        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   EqualityComparer<Person>.Default.Equals(Person, employee.Person);
        }

        public override int GetHashCode()
        {
            return 2099240096 + EqualityComparer<Person>.Default.GetHashCode(Person);
        }

        public override string ToString()
        {
            return Title + " " + Person.FirstName + " " + Person.LastName;
        }
    }
}
