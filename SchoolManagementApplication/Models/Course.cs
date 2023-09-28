namespace SchoolManagementApp.Models
{
    class Course
    {
        // A static counter to generate unique course IDs
        private static int CourseIdCounter = 1;

        public int Id { get; set; } // Property to access the course ID
        public string Name { get; set; } // Property to access the course name
        public Teacher AssignedTeacher { get; set; } // Property to access the assigned teacher
        public List<Student> EnrolledStudents { get; set; } // Property to access the list of enrolled students

        public Course(string name)
        {
            Id = CourseIdCounter++;  // Assigning a unique course ID and incrementing the counter
            Name = name; //Setting the course name
            EnrolledStudents = new List<Student>();  // Initializing the list of enrolled students as an empty list
        }

        public void AssignTeacher(Teacher teacher)
        {
            AssignedTeacher = teacher; // Assigning a teacher to the course
        }

        public void AssignStudent(Student student)
        {
            EnrolledStudents.Add(student); // Adding a student to the list of enrolled students for this course
        }
    }
}
