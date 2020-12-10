using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Inlamningsuppgift_2
{
    //This class represents the options. Struct did not work in this case and Enum was to complicated for this program
    public static class Menu
    {
        public const int options = 0;
        public const int showStudents = 1;
        public const int selectStudent = 2;
    }

    static class User_interractions
    {
        public const string ErrorMessage = "Invalid input";

        public static void Error()
        {
            Console.WriteLine(ErrorMessage);
        }
        public static string Menu(int menu, List<Student> student)
        {
            string listOfStudents = "";
            switch (menu)
            {
                case 0:
                    return "Welcome to the class of Götebuggarnas!\nChoose one of following:\n" +
                        "1. Show students in this class.\n" +
                        "2. Show details about a student.\n" +
                        "3. Remove a student from this class.\n" + 
                        
                        "9. Exit.\n";

                case 1:
                    listOfStudents = "\nClass members:\n";
                    for (int i = 0; i < student.Count; i++)
                    {
                        listOfStudents += $"{student[i].Name}";
                        if (i + 1 != student.Count)
                            listOfStudents += ", ";

                    }
                    return listOfStudents;

                case 2:
                    listOfStudents = "Choose wich student:\n";
                    for (int i = 0; i < student.Count; i++)
                        listOfStudents += $"{i + 1}. " + student[i].Name + "\n";
                    return listOfStudents;

                default:
                    Error();
                    break;
            }
            return "";
        }

        public static string ShowDetailes(int choise, List<Student> students)
        {
            try
            {
                Student s = students[choise - 1];
                return $"{s.Name} är {s.Age} år gammal och är född {s.Date}.\n" +
                    $"{s.Name} gillar att äta {s.FavoriteFood}. Bästa filmen {s.Name} har sätt är {s.FavoriteMovie} och lyssnar gärna på {s.FavoriteBand}.\n" +
                    $"{s.Name} gillar {s.Love} men hatar {s.Hate}. Kanske har något med sitt stjärntecken {s.Zodiac} att göra, vem vet :).\n" +
                    $"Om {s.Name} fick välja en superkraft skulle det vara {s.Superpower}.\n" +
                    $"{s.Name} största driv till programmering är {s.DriveForCoding}.\n";
            }
            catch { Error(); }
            return "";
        }

        public static bool DeleteMember(int choise, List<Student> studens)
        {
            if (choise <= studens.Count && choise > 0)
            {
                Console.WriteLine("Are you sure? J ?");
                if (Console.ReadLine().ToLower() == "j")
                {
                    Console.WriteLine($"{studens[choise - 1].Name} is now removed from class.");
                    return true;
                }
            }
            Error();
            return false;
        }
    }
}
