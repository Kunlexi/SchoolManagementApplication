namespace SchoolManagementApp.Models
{
    class Student : Person
    {
        private static int StudentIdCounter = 1;

        public int Id { get; }
        public int Age { get; set; }

        public Student(string name, int age) : base(name)
        {
            Id = StudentIdCounter++;
            Age = age;
        }
    }
}
