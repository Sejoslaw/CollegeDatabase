using CollegeDatabase.Persons;
using System;
using System.Collections.Generic;

namespace CollegeDatabase
{
    public class CollegeDb
    {
        // Static

        // Singleton
        private static CollegeDb INSTANCE = null;

        public static CollegeDb Instance
        {
            get
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new CollegeDb();
                }
                return INSTANCE;
            }
        }

        // Non Static

        /// <summary>
        /// Private Constructor
        /// </summary>
        private CollegeDb() { }

        public readonly Dictionary<Guid, IPerson<Guid>> People = new Dictionary<Guid, IPerson<Guid>>();

        public void AddPerson(IPerson<Guid> person)
        {
            this.People.Add(person.Id, person);
        }
    }
}