using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift_2
{
    class Student
    {
        private string name;
        private int age;
        private string date;
        private string favoriteFood;
        private string favoriteBand;
        private string favoriteMovie;
        private string love;
        private string hate;
        private string zodiac;
        private string superpower;
        private string driveForCoding;

        public Student(string name, int age, string date, string favoriteFood, string favoriteBand,
            string favoriteMovie, string love, string hate, string zodiac, string superpower, string driveForCoding)
        {
            this.name = name;
            this.age = age;
            this.date = date;
            this.favoriteFood = favoriteFood;
            this.favoriteBand = favoriteBand;
            this.favoriteMovie = favoriteMovie;
            this.love = love;
            this.hate = hate;
            this.zodiac = zodiac;
            this.superpower = superpower;
            this.driveForCoding = driveForCoding;
        }

        public string Name { get => name; }
        public int Age { get => age; }
        public string Date { get => date; }
        public string FavoriteFood { get => favoriteFood; }
        public string FavoriteBand { get => favoriteBand; }
        public string FavoriteMovie { get => favoriteMovie; }
        public string Love { get => love; }
        public string Hate { get => hate; }
        public string Zodiac { get => zodiac; }
        public string Superpower { get => superpower; }
        public string DriveForCoding { get => driveForCoding; }
    }
}
