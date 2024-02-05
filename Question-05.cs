// Write a Console Application program to display the multiplication table of a given number. Prompt the user to enter a number and display its multiplication table. (Use loops).

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Multiplication Table for {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}