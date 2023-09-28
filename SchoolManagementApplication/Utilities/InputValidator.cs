namespace SchoolManagementApp.Utilities
{
    class InputValidator
    {
        // InputValidator class implementation

        // Method to validate if input is numeric
        public static bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        // Method to validate if input is a valid age (between 5 and 100)
        public static bool IsValidAge(string input)
        {
            if (int.TryParse(input, out int age))
            {
                return age >= 5 && age <= 100;
            }
            return false;
        }

        // Method to validate if input is a non-empty string
        public static bool IsNotEmpty(string input)
        {
            return !string.IsNullOrEmpty(input);
        }

        // Method to validate if input is a valid subject (for teachers)
        public static bool IsValidSubject(string input)
        {
            // You can define your own rules for valid subjects here
            // For simplicity, let's assume any non-empty string is valid
            return IsNotEmpty(input);
        }

        // Method to validate if input is a valid course ID (positive integer)
        public static bool IsValidCourseId(string input)
        {
            if (int.TryParse(input, out int courseId))
            {
                return courseId > 0;
            }
            return false;
        }

        // Add more validation methods as needed based on your application's requirements
    }
}
