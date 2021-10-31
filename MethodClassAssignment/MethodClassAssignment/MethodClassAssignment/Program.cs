using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiOperation a = new MultiOperation();

            a.Times(20, 5);
            a.Times(num1: 10, num2: 10);
            Console.ReadLine();
        }
    }
}
