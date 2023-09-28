namespace SchoolManagementApp.Models
{
    class Person
    {
       // private static int IdCounter = 1;

      //  public int Id { get; private set; }
        public string Name { get; set; } // Property for the person's name

        public Person(string name)
        {
           // Id = IdCounter++;
            Name = name; // Set the name of the person
        }
    }
}
