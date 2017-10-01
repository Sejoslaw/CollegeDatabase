namespace CollegeDatabase.Persons
{
    /// <summary>
    /// Generyczny typ rodzaju identyfikatora.
    /// </summary>
    public interface IPerson<TId>
    {
        TId Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}