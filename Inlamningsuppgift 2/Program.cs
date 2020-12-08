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
                case "gotebuggarna":
                    Gotebuggarna gb = new Gotebuggarna();
                    gb.Run();
                    break;
                default:
                    break;
            }

        }
    }
}
