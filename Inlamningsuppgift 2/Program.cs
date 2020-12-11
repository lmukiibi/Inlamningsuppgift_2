using System;

namespace Inlamningsuppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! \nPleaase enter your code:");
            string code = Console.ReadLine().ToLower();
            Gotebuggarna gb = new Gotebuggarna();

            switch (code)
            {
                //case "":
                case "gotebuggarna":
                    Console.Clear();
                    gb.Run(false);
                    break;

                    //This populates the class with only one student so that you can adjust the logics and output of removing the student
                case "leemode":
                    Console.Clear();
                    gb.Run(true);
                    break;
                default:
                    Console.WriteLine(User_interractions.Terminating);
                    Console.ReadKey();
                    break;
            }

        }
    }
}
