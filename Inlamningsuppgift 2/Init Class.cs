using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift_2
{
    static class Init_Class
    {
        private static List<Student> students;
        public static List<Student> InitStudents(bool leeMode)
        {
            students = new List<Student>();

            AddStudent(leeMode);

            return students;
        }

        //Pupulates and returns a list of students. In this method you could add a code to download students from another sounce aswell
        private static List<Student> AddStudent(bool leeMode)
        {
            students.Clear();

            students.Add(new Student("Leroy", 32, "22 oct", "pizza", "We the best music", "Matrix",
                "choklad", "kaviar", "våg", "flyga", "dynamisk"));
            if (!leeMode)
            {
                students.Add(new Student("Andrei K", 26, "12 jan", "carbonara", "Two steps from hell", "Lord of the rings",
                    "resa", "oliver", "stenbock", "instant olive detection", "problemlösning"));
                students.Add(new Student("Jesper P", 28, "29 maj", "lammracks", "Lars Winnerbäck", "Catch me if you can",
                    "de enkla sakerna", "folk som filmar på konserter", "tvilling", "teleportering", "frihet"));
                students.Add(new Student("MA.Lin", 29, "13 mars", "rårakor", "Modest mouse", "Snach",
                    "höst/vinter", "banan", "fisk", "Mrs. Hindsight", "skapande"));
                students.Add(new Student("Gurra M", 33, "17 november", "tacos", "Berliner Philharmoniker", "Starwars",
                    "J.S Batch", "schlager", "scorpion", "tala med hundvalpa", "kreativitet"));
                students.Add(new Student("Johanna Wiberg", 30, "5 februari", "fisksoppa", "Full of hell", "Interstellar",
                    "musik", "kött", "vattuman", "odödlig", "tjurskallig"));
                students.Add(new Student("Linus N", 27, "17 juli", "fisksoppa", "Jack Moy", "The secret life of Walter Mitty",
                    "banan", "senap", "kräfta", "andas under vatten", "få ett riktigt skoj jobb"));
                students.Add(new Student("Nils O", 21, "15 mars", "pannkakor", "Beach Boys", "American psycho",
                    "snö", "slask", "fisk", "räkna med fingrarna", "roligt"));
                students.Add(new Student("Yulrok", 38, "23 april", "musli", "Morcheba", "The green book",
                    "ost", "slöseri", "oxe", "tankeövverföring", "biljett till digital nomad - livet"));
            }

            return students;
        }
    }
}
