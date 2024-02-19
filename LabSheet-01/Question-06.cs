// Create a C# console application that prompts the user to input a student's name and their exam marks. Based on the provided marks, determine, and display the corresponding grade for the student. The grading scale is as follows:
// •	If the marks are between 75 and 100 (inclusive), assign Grade A.
// •	For marks between 60 and 74 (inclusive), assign Grade B.
// •	For marks between 50 and 59 (inclusive), assign Grade C.
// •	For marks between 40 and 49 (inclusive), assign Grade D. 
// •	If the marks are below 40, the student has failed.
// •	Display the student's name along with their assigned grade at the end of the program.
// •	Validate the user input so that when the user inputs a value higher than 100 and less than 0 it displays an error message.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter student's name: ");
        string studentName = Console.ReadLine();

        Console.Write("Enter exam marks: ");
        int examMarks = Convert.ToInt32(Console.ReadLine());

        if (examMarks >= 0 && examMarks <= 100)
        {
            string grade;

            if (examMarks >= 75)
            {
                grade = "A";
            }
            else if (examMarks >= 60)
            {
                grade = "B";
            }
            else if (examMarks >= 50)
            {
                grade = "C";
            }
            else if (examMarks >= 40)
            {
                grade = "D";
            }
            else
            {
                grade = "Failed";
            }

            Console.WriteLine($"{studentName} - Grade: {grade}");
        }
        else
        {
            Console.WriteLine("ERROR: Please enter a valid exam mark between 0 and 100.");
        }
    }
}