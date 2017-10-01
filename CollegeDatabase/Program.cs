using CollegeDatabase.Factories;
using CollegeDatabase.Persons;
using System;
using System.Linq;

namespace CollegeDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton
            var db = CollegeDb.Instance;

            // Dodaj Profesorów
            db.AddPerson(new Professor("Andrzej", "Kowalski", "Prof."));
            db.AddPerson(new Professor("Monika", "Radzka", "Dr."));

            // Dodaj studentów
            db.AddPerson(new Student("Jan", "Rybak", Guid.NewGuid()));
            db.AddPerson(new Student("Krzysztof", "Dobrzyński", Guid.NewGuid()));
            db.AddPerson(new Student("Maria", "Łudzka", Guid.NewGuid()));

            // Znajdz Jana przy użyciu zapytania LINQ
            var studentJan = db.People.Where(pair => pair.Value.FirstName.Equals("Jan")).First().Value;

            // Wypisz Osoby
            db.People.ToList().ForEach(pair =>
            {
                Console.WriteLine(pair.Value + Environment.NewLine);
            });
            Console.WriteLine("=========================" + Environment.NewLine);

            // Fabryka Ocen
            var degreeFabric = DegreeFactory.NewFactory();
            degreeFabric.AddDegreeForPerson(studentJan, 4);
            degreeFabric.AddDegreeForPerson(studentJan, 3);
            degreeFabric.AddDegreeForPerson(studentJan, 5);

            // Wypisz rezultat
            degreeFabric.Degrees.ToList().ForEach(pair =>
            {
                pair.Value.ForEach(value =>
                {
                    Console.WriteLine($"Person Id = { pair.Key }, Degree = { value }");
                });
            });
            Console.WriteLine("=========================" + Environment.NewLine);

            // Udekoruj Jana
            var decorator = new StudentDecorator(studentJan as Student);
            Console.WriteLine(Environment.NewLine + decorator.ToString());
            Console.WriteLine(Environment.NewLine + decorator.FirstName);

            Console.ReadKey();
        }
    }
}