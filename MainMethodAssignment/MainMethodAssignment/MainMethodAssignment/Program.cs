using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation a = new MathOperation();
            int x = a.Subtraction(42);
            double p = a.Subtraction(24.7m);
            int z = a.Subtraction("10");

            Console.WriteLine(x);
            Console.WriteLine(p);
            Console.WriteLine(z);

            Console.ReadLine();
        }
    }
}
