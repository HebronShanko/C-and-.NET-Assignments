using System;


namespace BranchingAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
       

            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());


           
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");              
            }

            else
            {


                Console.WriteLine("Please enter the package width:");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package lenght:");
                int packageLenght = Convert.ToInt32(Console.ReadLine());


                int totalDemensions = (packageWidth + packageLenght + packageHeight);

                if (totalDemensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                }

                else
                {
                    int product = (packageWidth * packageHeight * packageLenght) * packageWeight;
                    decimal estimatedQuote = Convert.ToDecimal(product / 100);

                    Console.WriteLine("This is how much it costs to ship $ " + estimatedQuote);
                }

              
            }

              Console.ReadLine();
            



        }  
    }
}
