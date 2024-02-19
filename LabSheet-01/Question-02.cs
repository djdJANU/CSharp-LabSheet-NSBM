// Write a Console Application program to check if the given 10 number inputs are even or odd. Prompt the user to enter the numbers, and display whether it's even or odd. 

using System;

class Program
{
    static void Main()
    {
        const int numberOfInputs = 10;

        Console.WriteLine($"Enter {numberOfInputs} numbers:");

        for (int i = 1; i <= numberOfInputs; i++)
        {
            Console.Write($"Number {i}: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput % 2 == 0)
            {
                Console.WriteLine($"Number {userInput} is even.");
            }
            else
            {
                Console.WriteLine($"Number {userInput} is odd.");
            }
        }
    }
}