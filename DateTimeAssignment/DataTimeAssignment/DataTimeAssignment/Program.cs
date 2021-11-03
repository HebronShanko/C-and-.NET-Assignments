using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            DateTime newTime = DateTime.Now.AddHours(number);
            Console.WriteLine(newTime);
            Console.ReadLine();
        }
        
    }
}
