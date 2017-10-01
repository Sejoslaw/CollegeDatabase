using CollegeDatabase.Factories;
using CollegeDatabase.Persons;
using System;
using Xunit;

namespace CollegeDatabase.UnitTests
{
    public class UnitTest
    {
        [Fact]
        public void Test_if_database_was_created_add_entities_were_added()
        {
            // Singleton
            var db = CollegeDb.Instance;

            // Dodaj Profesor�w
            db.AddPerson(new Professor("Andrzej", "Kowalski", "Prof."));
            db.AddPerson(new Professor("Monika", "Radzka", "Dr."));

            // Dodaj student�w
            db.AddPerson(new Student("Jan", "Rybak", Guid.NewGuid()));
            db.AddPerson(new Student("Krzysztof", "Dobrzy�ski", Guid.NewGuid()));
            db.AddPerson(new Student("Maria", "�udzka", Guid.NewGuid()));

            Assert.True(db.People.Count == 5);
        }

        [Fact]
        public void Test_if_Degree_Fabric_added_degrees()
        {
            var studentJan = new Student("Jan", "Rybak", Guid.NewGuid());

            // Fabryka Ocen
            var degreeFabric = DegreeFactory.NewFactory();
            degreeFabric.AddDegreeForPerson(studentJan, 4);
            degreeFabric.AddDegreeForPerson(studentJan, 3);
            degreeFabric.AddDegreeForPerson(studentJan, 5);

            Assert.True(degreeFabric.Degrees.Count == 1);
            Assert.True(degreeFabric.Degrees[studentJan.Id].Count == 3);
        }
    }
}