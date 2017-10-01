using System;

namespace CollegeDatabase.Persons
{
    public abstract class AbstractPerson : IPerson<Guid>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}