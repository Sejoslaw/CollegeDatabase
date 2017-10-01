namespace CollegeDatabase.Persons
{
    /// <summary>
    /// Dekorator
    /// </summary>
    public class StudentDecorator
    {
        Student Student { get; set; }

        public string FirstName
        {
            get
            {
                return this.Student.FirstName + " (udekorowane imie Studenta)";
            }
        }

        public StudentDecorator(Student student)
        {
            this.Student = student;
        }

        /// <summary>
        /// Udekoruj metode - dodaj coś do podstawowej metody z obiektu przekazanego w konstruktorze.
        /// </summary>
        public override string ToString()
        {
            return this.Student + " - udekorowany";
        }
    }
}