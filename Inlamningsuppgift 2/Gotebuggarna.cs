using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Inlamningsuppgift_2
{
    class Gotebuggarna
    {
        private bool running;

        public Gotebuggarna()
        {
            running = false;
        }

        

        public void Run()
        {
            while (true)
            {
                Console.ReadKey();
            }
        }
    }
}
