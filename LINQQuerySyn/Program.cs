using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQQuery{
    class famousPeople
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
            };

            //LINQ

            var greaterThanNineteen = stemPeople.Where(s => s.BirthYear > 1900)
                                              .OrderByDescending(s => s.BirthYear).ToList<famousPeople>();
            Console.WriteLine("Here are the years after 1900");
            foreach (famousPeople std in greaterThanNineteen)
            {
                Console.WriteLine(std.BirthYear);
            }

            Console.WriteLine(" ");

            var lowerLL = from s in stemPeople
                          where s.Name.Contains("ll")
                          select s;
            Console.WriteLine("These people have a double L in their name:");
            foreach (famousPeople std in lowerLL)
            {
                Console.WriteLine(std.Name);
            }

            Console.WriteLine(" ");

            var countAfter1950 = stemPeople.Count(s => s.BirthYear > 1950);
            Console.WriteLine("Heres how many people are born after 1950: " +countAfter1950);

            Console.WriteLine(" ");

            var BetweenDate = stemPeople.Where(s => s.BirthYear >= 1920 && s.BirthYear <= 2000)
                                              .OrderByDescending(s => s.BirthYear).ToList<famousPeople>();
            Console.WriteLine("Here are the years between 1920 and 2000");
            foreach(famousPeople std in BetweenDate)
            {
                Console.WriteLine(std.BirthYear);
            }

            Console.WriteLine(" ");

            var BetweenDate2 = stemPeople.Where(s => s.DeathYear > 1960 && s.DeathYear < 2015)
                                              .OrderBy(s => s.DeathYear).ToList<famousPeople>();
            Console.WriteLine("Here are the people who died between 1960 and 2015");
            foreach (famousPeople std in BetweenDate2)
            {
                Console.WriteLine(std.Name);
            }
        }
    }
}