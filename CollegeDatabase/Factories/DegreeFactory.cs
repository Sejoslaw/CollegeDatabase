using CollegeDatabase.Persons;
using System;
using System.Collections.Generic;

namespace CollegeDatabase.Factories
{
    /// <summary>
    /// Fabryka
    /// </summary>
    public class DegreeFactory : IDegreeFactory<IPerson<Guid>>
    {
        // Static

        public static IDegreeFactory<IPerson<Guid>> NewFactory()
        {
            return new DegreeFactory();
        }

        // Non Static

        Dictionary<Guid, List<int>> degrees = new Dictionary<Guid, List<int>>();

        public Dictionary<Guid, List<int>> Degrees
        {
            get
            {
                return this.degrees;
            }
        }

        private DegreeFactory() { }

        public void AddDegreeForPerson(IPerson<Guid> entity, int degree)
        {
            // Search if record exists
            foreach (var pair in this.degrees)
            {
                if (pair.Key == entity.Id)
                {
                    AddDegreeForPerson(pair.Value, degree);
                    return;
                }
            }
            // If record not exists, create new
            var list = new List<int>();
            this.degrees.Add(entity.Id, list);
            AddDegreeForPerson(list, degree);
        }

        private void AddDegreeForPerson(List<int> list, int degree)
        {
            list.Add(degree);
        }
    }
}