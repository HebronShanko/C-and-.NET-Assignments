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
            int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Have you ever had a DUI?");
            //bool hasDUI = true;Console.WriteLine(hasDUI);


            Console.WriteLine("Have you ever had a DUI? Please answer with true or false");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());
            

            Console.WriteLine("How many speeding tickets do you have?");
            int hasSpeedingTickets = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Approved?");
            if (age >= 16 && hasDUI == false && hasSpeedingTickets <= 3)
            {
                Console.WriteLine("You are approved");
            }

            else
            {
                Console.WriteLine("Not Approved");

            }

            Console.ReadLine();
            

        }
    }
}
