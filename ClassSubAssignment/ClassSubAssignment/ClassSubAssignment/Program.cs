using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number  is divided by 2 
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());

            Divide p = new Divide();
            p.Division(x);

            //out Parameter

            int a = 8;
            Console.WriteLine("Call value of a: {0}", a);
            p.Division(out a);

            Console.WriteLine("After method call, value of a: {0}", a);
            Console.ReadLine();
        }
    }
}
