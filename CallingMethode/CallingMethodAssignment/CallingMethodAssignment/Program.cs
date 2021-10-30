using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int Input = Convert.ToInt32(Console.ReadLine());

            Operations doOperation = new Operations();

            int resultAdd = doOperation.Addition(Input);
            int resultSubtract = doOperation.Subtraction(Input);
            int resultMultiply = doOperation.Multiplication(Input);


            Console.WriteLine(resultAdd);
            Console.WriteLine(resultSubtract);
            Console.WriteLine(resultMultiply);

            Console.ReadLine();
        }
    }
}
