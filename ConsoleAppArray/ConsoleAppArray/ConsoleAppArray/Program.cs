using System;
using System.Collections.Generic;


namespace ConsoleAppArray
{
    class Program
    {
        static void Main()
        {

            int[] numArray = new int[] { 5, 9, 44, 65, 19, 7, 2, 89, 45, 63, 20 };      
            Console.WriteLine("Type an Index number 0 through 10?");
            int index = int.Parse(Console.ReadLine());

            if (index > 10)
            {
                Console.WriteLine("Index number does not exist");
            }
            else
            {
                Console.WriteLine("value is: " + numArray[index]);
                Console.ReadLine();
            }

            string[] stringArray = new string[] { "red", "blue", "purple", "black", "green", "yellow", "white", "gray", "tan", "orange", "pink" };
            Console.WriteLine("Type an Index number 0 through 10?");
            int index1 = int.Parse(Console.ReadLine());

            if ( index1 > 10)
            {
                Console.WriteLine("Index number does not exist");
            }
            else
            {
                Console.WriteLine("value is: " + stringArray[index1]);
                Console.ReadLine();
            }

            List<string> intList = new List<string>();
            intList.Add("Hello!");
            intList.Add("Hi!");
            intList.Add("Hey!");
            intList.Add("What's Good!");

            Console.WriteLine("Type an Index number 0 through 3?");

            int index2 = int.Parse(Console.ReadLine());
            Console.WriteLine("value is: " + intList[index2]);
            Console.ReadLine();


        }
    }
}
