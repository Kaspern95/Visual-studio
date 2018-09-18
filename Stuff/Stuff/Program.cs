using System;

namespace Stuff
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Things";
            Console.WindowWidth = 100;
            Console.WindowHeight = 20;
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Please input your height in cm:");
            string getHeight = Console.ReadLine();
            double newHeight = double.Parse(getHeight);
            double height = Math.Pow(newHeight, 2);
            Console.WriteLine($"Your height is {newHeight}cm.");
            
            
           



           

            Console.ReadLine();

        }
         
    }
}
