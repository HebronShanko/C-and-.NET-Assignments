using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();

            example.FirstName = "Bob";
            example.LastName = "Waters";
            example.ID = 252525;

            Employee example2 = new Employee();

            example2.FirstName = "Andy";
            example2.LastName = "Reid";
            example2.ID = 343434;

            bool condition = true;
            if (example == example2)
            {
                Console.WriteLine("Its equal");
            }
            else
            {
                Console.WriteLine("It is not equal");
            }


            Console.ReadLine();
        }
    }
}
