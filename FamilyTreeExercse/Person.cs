namespace FamilyTreeExercse
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? BirthYear { get; set; }
        public int? DeathYear { get; set; }
        public Person Father { get; set; }
        public Person Mother { get; set; }

        public Person(string firstName, int? birthYear = null, string lastName = null, int? deathYear = null)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            DeathYear = deathYear;
        }

        public Person(string firstName, int birthYear, int deathYear)
            :this(firstName, birthYear, null, deathYear)
        {
        }
    }
}
