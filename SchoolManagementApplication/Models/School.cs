namespace SchoolManagementApp.Models
{
    class School
    {
        private string Name { get; set; } // Property to store the name of the school
        public List<Student> Students { get; set; } // Property to store a list of students
        public List<Teacher> Teachers { get; set; } // Property to store a list of teachers
        public List<Course> Courses { get; set; } // Property to store a list of courses

        public School(string name) // Initialize the school's name
        {
            Name = name; // Initialize the school's name
            Students = new List<Student>(); // Initialize the list of students as an empty list
            Teachers = new List<Teacher>(); // Initialize the list of teachers as an empty list
            Courses = new List<Course>(); // Initialize the list of courses as an empty list
        }

        public void RegisterStudent(Student student)
        {
            Students.Add(student); // Add a student to the list of students in the school
        }

        public void RegisterTeacher(Teacher teacher)
        {
            Teachers.Add(teacher); // Add a teacher to the list of teachers in the school
        }

        public void CreateCourse(Course course)
        {
            Courses.Add(course); // Creating and adding a course to the list of courses in the school
        }

        public bool AssignTeacherToCourse(int teacherId, int courseId)
        {
            Teacher teacher = Teachers.Find(t => t.Id == teacherId); // Find the teacher by ID
            Course course = Courses.Find(c => c.Id == courseId); // Find the course by ID

            if (teacher != null && course != null) 
            {
                course.AssignTeacher(teacher); // Assigning the teacher to the course
                return true;
            }

            return false; // Return false if either the teacher or course was not found
        }

        public bool AssignStudentToCourse(int studentId, int courseId)
        {
            Student student = Students.Find(s => s.Id == studentId); // Find the student by ID
            Course course = Courses.Find(c => c.Id == courseId); // Find the course by ID

            if (student != null && course != null) 
            {
                course.AssignStudent(student); // Assign the student to the course
                return true;
            }

            return false; // Return false if either the student or course was not found
        }
    }
}
