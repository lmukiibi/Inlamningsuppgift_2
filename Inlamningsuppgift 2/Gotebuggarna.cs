using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Inlamningsuppgift_2
{
    class Gotebuggarna
    {
        private bool running;
        private List<Student> students;

        public Gotebuggarna()
        {
            running = true;
        }

        public void Run(bool leeMode)
        {
            students = Init_Class.InitStudents(leeMode);

            int choise = 0;
            while (running)
            {
                //This line displays options
                Console.WriteLine(User_interractions.Menu(Menu.options, students));
                try
                {
                    choise = int.Parse(Console.ReadLine());
                    switch (choise)
                    {
                        //Show class members
                        case 1:
                            if (students.Count == 0)
                            {
                                Console.WriteLine(User_interractions.NoStudents);
                                break;
                            }
                            Console.WriteLine(User_interractions.Menu(Menu.showStudents, students));
                            break;
                        //Select class member to show details
                        case 2:
                            if (students.Count == 0)
                            {
                                Console.WriteLine(User_interractions.NoStudents);
                                break;
                            }
                            Console.WriteLine(User_interractions.Menu(Menu.selectStudent, students));
                            Console.WriteLine(User_interractions.ShowDetailes(int.Parse(Console.ReadLine()), students));
                            break;
                            //Removes member from class
                        case 3:
                            if (students.Count == 0)
                            {
                                Console.WriteLine(User_interractions.NoStudents);
                                break;
                            }
                            Console.WriteLine(User_interractions.Menu(Menu.selectStudent, students));
                            try
                            {
                                

                                int selected = Convert.ToInt32(Console.ReadLine());
                                if (User_interractions.DeleteMember(selected, students))
                                {
                                    students.RemoveAt(selected - 1);
                                }
                            }
                            catch { User_interractions.Error(); }
                            break;
                        case 4:
                            students = Init_Class.InitStudents(leeMode);
                            Console.WriteLine(User_interractions.StudentsAdded);
                            break;

                        //This line ends the loop
                        case 9:
                            running = false;
                            Console.WriteLine(User_interractions.GoodBye);
                            break;
                        default:
                            User_interractions.Error();
                            break;

                    }

                }
                catch { User_interractions.Error(); }
                Console.WriteLine(User_interractions.PressKey);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
