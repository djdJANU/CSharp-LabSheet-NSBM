//Write a Console Application program to print the first N terms of the Fibonacci series. Prompt the user to enter the value of N. (Use recursion)

class Program

{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}