using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Weeks day = new Weeks();

            try
            {
                Console.WriteLine("Enter the current day of the week", day);
                Weeks.DaysOfTheWeek answer = (Weeks.DaysOfTheWeek)Enum.Parse(typeof(Weeks.DaysOfTheWeek), Console.ReadLine());

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter and acuall day of the week", day);
            }
        }
    }
}
