using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            Console.WriteLine();
            employee.SayName();
            IQuittable emp1 = new Employee();
            emp1.Quit();

            Console.ReadLine();
        }
    }
}
