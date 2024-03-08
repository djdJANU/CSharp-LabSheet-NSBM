//Design a C# class named Course that encapsulates information about a student's course and demonstrates proper use of access specifiers and properties.

using System;
namespace CourseInformation
{
    class Course
    {
        private string courseName;
        private string instructorName;
        private double grade;

        public string CourseName
        {
            get { return courseName; }
        }

        public double Grade
        {
            get { return grade; }
        }

      
        public Course(string courseName, string instructorName, double grade)
        {
            this.courseName = courseName;
            SetInstructorName(instructorName);
            SetGrade(grade);
        }
         
        public void SetInstructorName(string instructorName)
        {
            if (string.IsNullOrEmpty(instructorName))
            {
                throw new ArgumentException("Instructor name cannot be empty.");
            }
            this.instructorName = instructorName;
        }

        private string CalculateLetterGrade(double grade)
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }

        public void SetGrade(double grade)
        {
            if (grade < 0 || grade > 100)
            {
                throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");
            }
            this.grade = grade;
        }

        public void PrintCourseInfo()
        {
            string letterGrade = CalculateLetterGrade(grade);
            Console.WriteLine($"Course Name: {courseName}");
            Console.WriteLine($"Instructor Name: {instructorName}");
            Console.WriteLine($"Letter Grade: {letterGrade}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course("OOP with C#", "Anton", 82);
            course.PrintCourseInfo();

            Console.ReadLine(); 
            }
    }
}
