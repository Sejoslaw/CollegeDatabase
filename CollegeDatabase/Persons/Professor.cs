using System;

namespace CollegeDatabase.Persons
{
    public class Professor : AbstractPerson
    {
        // Dodatkowe pole dla Profesora
        public string Title { get; set; }

        public Professor(string firstName, string lastName, string title)
        {
            this.Id = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Title = title;
        }

        public override string ToString()
        {
            return $"Professor[Id = { this.Id }, First Name = { this.FirstName }, Last Name { this.LastName }, Title = { this.Title }]";
        }
    }
}