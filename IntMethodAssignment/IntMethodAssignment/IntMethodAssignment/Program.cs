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
           

            TwoInt myMath = new TwoInt();

            try
            {
                Console.WriteLine("Enter a second number");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(myMath.Subtraction(x, y));
            }
            catch(FormatException)
            {

                Console.WriteLine(myMath.Subtraction(x, 23));
            }
            Console.ReadLine();
        }

    }
}
