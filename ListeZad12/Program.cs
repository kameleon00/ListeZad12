using System;
using System.Collections.Generic;

namespace ListeZad12
{
    class Program
    {
        static void Main(string[] args)
        {
            //kreiramo listu student
            List<Student> student = new List<Student>()
            {
                new Student("Pera", "Peric", 89),
                new Student("Mika", "Mikic", 95),
                new Student("Luka", "Lukic", 30),
                new Student("Laza", "Lazic", 60),
                new Student("Milos", "Milosevic", 51),
            };

            //dodavanje studenata
            student.Add(new Student("Djordje", "Djordjevic", 76));
            student.Add(new Student("Zika", "Zikic", 21));

            //ispis liste studenata pozivom ToString metode
            Console.WriteLine("Ispis studenata nakon dodavanja Add metodom");
            foreach (Student s in student)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("=========================================================");

            // Ispis trenutnog broja elemenata u listi
            Console.WriteLine("Ispis trenutnog broja studenata u listi Count metodom.");
            Console.WriteLine("Ispit je polagalo {0} studenata.", student.Count);
            Console.WriteLine("=========================================================");

            // Ispis kapaciteta liste
            Console.WriteLine("Ispis kapaciteta liste primenom Capacity metode,");
            Console.WriteLine("Kapacitet liste je {0}", student.Capacity);
            Console.WriteLine("=========================================================");


            // Uklanjanje elementa sa indeksom 3 iz liste sa ispisom
            student.RemoveAt(3);
            Console.WriteLine("Ispis nakon removeAt metode.");
            foreach (Student s in student)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("=========================================================");

            // Dodavanje elementa na indeks 2 u listu sa ispisom
            student.Insert(2, new Student("Ana ", "Anic", 78));
            Console.WriteLine("Ispis nakon Insert metode.");
            foreach (Student s in student)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("=========================================================");

            // Dodavanje nove liste elemenata sa ispisom
            student.InsertRange(student.Count, new List<Student>
            {
                new Student("Ivana", "Ivanic", 99),
                new Student("Maja", "Majic", 22), 
                new Student("Olja", "Oljic", 76)
            });
            Console.WriteLine("Ispis nakon InsertRange metoda");
            foreach (Student s in student)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("=========================================================");

            // Uklanjanje elementa vise elemenata iz liste sa ispisom
            student.RemoveRange(3, 3);
            Console.WriteLine("Ispis nakon RemoveRange metoda");
            foreach (Student s in student)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("=========================================================");


            Console.ReadLine();
        }
    }
}