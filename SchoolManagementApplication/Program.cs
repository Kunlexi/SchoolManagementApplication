using SchoolManagementApp.Models;

namespace SchoolManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new School instance with the name "My School"

            School school = new School("My School");

            while (true)
            {
                // Displaying menu options to the user
                Console.WriteLine("School Management System");
                Console.WriteLine("1. Register Student");
                Console.WriteLine("2. Register Teacher");
                Console.WriteLine("3. Create Course");
                Console.WriteLine("4. Assign Teacher to Course");
                Console.WriteLine("5. Assign Student to Course");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");

                // Reading the user's choice as an integer
                if (int.TryParse(Console.ReadLine(), out int choice))
                {

                    // Using a switch statement to execute the selected option
                    switch (choice)
                    {
                        case 1:
                            RegisterStudent(school);
                            break;
                        case 2:
                            RegisterTeacher(school);
                            break;
                        case 3:
                            CreateCourse(school);
                            break;
                        case 4:
                            AssignTeacherToCourse(school);
                            break;
                        case 5:
                            AssignStudentToCourse(school);
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric option.");
                }
            }
        }

        // Function to register a new student
        private static void RegisterStudent(School school)
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student age: ");
            int age;
            if (int.TryParse(Console.ReadLine(), out age))
            {
                // Create a new Student object and register it with the school
                Student student = new Student(name, age);
                school.RegisterStudent(student);
                Console.WriteLine("Student registered successfully.");
            }
            else
            {
                Console.WriteLine("Invalid age. Please enter a numeric age.");
            }
        }

        // Function to register a new teacher
        private static void RegisterTeacher(School school)
        {
            Console.Write("Enter teacher name: ");
            string name = Console.ReadLine();
            Console.Write("Enter teacher subject: ");
            string subject = Console.ReadLine();
            Teacher teacher = new Teacher(name, subject);
            school.RegisterTeacher(teacher);
            Console.WriteLine("Teacher registered successfully.");
        }

        // Function to create a new course
        private static void CreateCourse(School school)
        {
            Console.Write("Enter course name: ");
            string name = Console.ReadLine();
            Course course = new Course(name);
            school.CreateCourse(course);
            Console.WriteLine("Course created successfully.");
        }

        // Function to assign a teacher to a course
        private static void AssignTeacherToCourse(School school)
        {
            DisplayTeachers(school.Teachers);
            DisplayCourses(school.Courses);
            Console.Write("Enter teacher ID: ");
            if (int.TryParse(Console.ReadLine(), out int teacherId))
            {
                Console.Write("Enter course ID: ");
                if (int.TryParse(Console.ReadLine(), out int courseId))
                {
                    if (school.AssignTeacherToCourse(teacherId, courseId))
                    {
                        Console.WriteLine("Teacher assigned to the course successfully.");

                        // Display the updated course information
                        Course course = school.Courses.Find(c => c.Id == courseId);
                        if (course != null)
                        {
                            Console.WriteLine($"Course Name: {course.Name}");
                            Console.WriteLine($"Assigned Teacher: {course.AssignedTeacher?.Name ?? "None"}");
                            Console.WriteLine("Enrolled Students:");
                            foreach (var student in course.EnrolledStudents)
                            {
                                Console.WriteLine($"{student.Name}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Teacher or course not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid course ID. Please enter a numeric course ID.");
                }
            }
            else
            {
                Console.WriteLine("Invalid teacher ID. Please enter a numeric teacher ID.");
            }
        }

        private static void DisplayCourses(List<Course> courses)
        {
            Console.WriteLine("Available Courses:");
            foreach (var course in courses)
            {
                Console.WriteLine($"ID: {course.Id}, Name: {course.Name}");
            }
        }

        // Function to display a list of courses
        private static void DisplayTeachers(List<Teacher> teachers)
        {
            Console.WriteLine("Available Teachers:");
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"ID: {teacher.Id}, Name: {teacher.Name}");
            }
        }

        // Function to assign a student to a course
        private static void AssignStudentToCourse(School school)
        {
            DisplayStudents(school.Students);
            DisplayCourses(school.Courses);
            Console.Write("Enter student ID: ");
            if (int.TryParse(Console.ReadLine(), out int studentId))
            {
                Console.Write("Enter course ID: ");
                if (int.TryParse(Console.ReadLine(), out int courseId))
                {
                    if (school.AssignStudentToCourse(studentId, courseId))
                    {
                        Console.WriteLine("Student assigned to the course successfully.");

                        // Displaying the updated course information
                        Course course = school.Courses.Find(c => c.Id == courseId);
                        if (course != null)
                        {
                            Console.WriteLine($"Course Name: {course.Name}");
                            Console.WriteLine($"Assigned Teacher: {course.AssignedTeacher?.Name ?? "None"}");
                            Console.WriteLine("Enrolled Students:");
                            foreach (var student in course.EnrolledStudents)
                            {
                                Console.WriteLine($"{student.Name}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Student or course not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid course ID. Please enter a numeric course ID.");
                }
            }
            else
            {
                Console.WriteLine("Invalid student ID. Please enter a numeric student ID.");
            }
        }

        // Function to display a list of students
        private static void DisplayStudents(List<Student> students)
        {
            Console.WriteLine("Available Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            }
        }


    }
}
