using System;
using System.Collections.Generic;


namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            string index = Console.ReadLine();
            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine( weekDays[i] += index);

            }

            Console.Write("Search for day:");
            string inputSearch = Console.ReadLine();
            bool dayFound = false;
            for (int i = 0; i < weekDays.Length; i++)
            {
                if (weekDays[i] == inputSearch)
                {
                    Console.WriteLine("Model: " + weekDays[i]);
                    dayFound = true;
                }
            }
            if (!dayFound) { Console.WriteLine("No days were found"); }

            Console.ReadLine();

            // Step 1: create an array of with two identical strings.
            List<string> pets = new List<string>{ "dog", "cat", "bird", "fish", "dog"};
            List<string> pet = new List<string>();


            // Step 2: loop with the foreach keyword.
            foreach (string value in pets)
            {
                if (!pet.Contains(value))
                {
                    pet.Add(value);
                    Console.WriteLine(value + "pet does not exist yet");
                }
                else if ( pet.Contains(value))
                {
                    Console.WriteLine(value + "pet already exists");
                }

            }



        }

    }
}
