using System;

namespace Inlamningsuppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! \nPleaase enter your code:");
            string code = Console.ReadLine().ToLower();

            switch (code)
            {
                case "":
                //case "gotebuggarna":
                    Gotebuggarna gb = new Gotebuggarna();
                    Console.Clear();
                    gb.Run();
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Input not valid. Terminating program.");
                    Console.ReadKey();
                    break;
            }

        }
    }
}
