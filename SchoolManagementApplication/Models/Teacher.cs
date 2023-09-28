namespace SchoolManagementApp.Models
{
    class Teacher : Person  // Teacher class inherits from the Person class
    {
        private static int TeacherIdCounter = 1;  // A static counter to generate unique teacher IDs

        public int Id { get; }  // Public property to access the teacher ID
        public string Subject { get; set; }  // Public property to access the subject taught by the teacher


        public Teacher(string name, string subject) : base(name)  // Constructor that takes the teacher's name and subject
        {
            Id = TeacherIdCounter++; // Assigning a unique teacher ID and increment the counter
            Subject = subject;  // Setting the subject taught by the teacher
        }
    }
}
