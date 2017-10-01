using System;
using System.Collections.Generic;

namespace CollegeDatabase.Factories
{
    public interface IDegreeFactory<TEntityType>
    {
        Dictionary<Guid, List<int>> Degrees { get; }

        void AddDegreeForPerson(TEntityType entity, int v);
    }
}