using System;


namespace MathandComparison_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("What is your hourly rate?");
            int hourlyRate1 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hours worked per week?");
            int weeklyHours1 = int.Parse(Console.ReadLine());
            int salary1 = hourlyRate1 * weeklyHours1 * 52;
            Console.WriteLine("Your Annual salary is: " + salary1);
            Console.ReadLine();


            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("What is your hourly rate?");
            int hourlyRate2 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hours worked per week?");
            int weeklyHours2 = int.Parse(Console.ReadLine());
            int salary2 = hourlyRate2 * weeklyHours2 * 52;
            Console.WriteLine("Your Annual salary is: " + salary2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool biggerSalary = salary1 > salary2;
            Console.WriteLine(biggerSalary);
            Console.ReadLine();


        }
    }
}
