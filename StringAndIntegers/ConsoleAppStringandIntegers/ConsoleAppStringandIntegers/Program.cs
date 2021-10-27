using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringandIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = false;
            while (!active)
            {
                try
                {
                    List<int> intList = new List<int>() { 20, 6, 9, 52, 40, 74 };       //new list
                    Console.WriteLine("Pick a number");
                    int userNumber = Convert.ToInt32(Console.ReadLine());

                    foreach (int i in intList)
                    {
                        int results = i / userNumber;
                        Console.WriteLine(results);
                        active = true;

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Type a whole number");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Please don't not pick zero");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }
            }
     
            
            
        }
    }
}
