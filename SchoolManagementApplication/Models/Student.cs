namespace SchoolManagementApp.Models
{
    class Student : Person // Student class inherits from the Person class
    {
        private static int StudentIdCounter = 1; // A static counter for generating unique student IDs

        public int Id { get; } // Public property to access the student's ID
        public int Age { get; set; } // Public property to access and set the student's age

        public Student(string name, int age) : base(name) // Constructor that takes the student's name and age, and calls the base constructor
        {
            Id = StudentIdCounter++; // Assign a unique student ID and increment the counter
            Age = age; // Set the student's age
        }
    }
}
