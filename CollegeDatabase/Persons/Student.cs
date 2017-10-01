using System;

namespace CollegeDatabase.Persons
{
    public class Student : AbstractPerson
    {
        // Dodatkowe pole dla Studenta
        public Guid GroupId { get; set; }

        public Student(string firstName, string lastName, Guid groupId)
        {
            this.Id = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.GroupId = groupId;
        }

        public override string ToString()
        {
            return $"Student[Id = { this.Id }, First Name = { this.FirstName }, Last Name { this.LastName }, Group Id = { this.GroupId }]";
        }
    }
}