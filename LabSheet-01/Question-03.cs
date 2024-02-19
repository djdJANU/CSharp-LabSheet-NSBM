// Write a Console Application program to calculate the sum of all numbers from 1 to a given positive integer. Prompt the user to enter a positive integer and display the sum. If the user inputs a negative value it should display “ERROR”. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput > 0)
        {
            int sum = 0;
            for (int i = 1; i <= userInput; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum of numbers from 1 to {userInput}: {sum}");
        }
        else
        {
            Console.WriteLine("ERROR: Please enter a positive integer.");
        }
    }
}