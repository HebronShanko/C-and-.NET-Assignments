using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int y = Convert.ToInt32(Console.ReadLine());

            TwoInt myMath = new TwoInt();
            if (y == 0)
            {
                int result = myMath.Subtraction(x);
                Console.WriteLine(result);

            }
            else
            {
                int result = myMath.Subtraction(x, y);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
