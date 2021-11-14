using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome Back {uName}. Today is {date}.  ";
            Console.WriteLine(msg);

            string path = @"C:\Users\hebro\OneDrive\Documents\GitHub\C-and-.NET-Assignments\Console.NetCore\Scores\Scores\studentScores";
            string[] lines = System.IO.File.ReadAllLines(path);


            double tScore = 0.0;


            Console.WriteLine("\nStudnet Scores: \n");
            foreach (string line in lines)
            {
                Console.WriteLine("\n + line");
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotoal of " + lines.Length + " student scores. \tAverage score: " + avgScore);




            Console.WriteLine("\n\nPress any key to exist. ");
            Console.ReadLine();

        }
    }
}
