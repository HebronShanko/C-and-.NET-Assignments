using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            //int age = 18;
            //bool hasDUI = false;
            //int hasSpeedingTickets = 3;

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Have you ever had a DUI?");
            //bool hasDUI = true;Console.WriteLine(hasDUI);


            Console.WriteLine("Have you ever had a DUI? Please answer with True or False");
            bool hasDUI = false;
            string DUIStatus = Convert.ToString(hasDUI);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int hasSpeedingTickets = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Approved?");
            bool insuraceApproved = (age >= 15 && !hasDUI && hasSpeedingTickets <= 3);
            Console.WriteLine(insuraceApproved);
            Console.ReadLine();

        }
    }
}
