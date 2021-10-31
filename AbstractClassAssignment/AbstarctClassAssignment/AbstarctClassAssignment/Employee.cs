using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClassAssignment
{
    public class Employee: Person
    {
        public void SayName(string FirstName, string LastName)
        {
            base.SayName();
        }
        
    }
}
