
// 1.	Create a C# console application that defines a class called Book with properties Title and Author. Instantiate an object of this class, set values for the properties, and display the information on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

class program
{
    static void Main(string[] args)
    {
        Book myBook = new Book();

        myBook.Title = "The Great Gatsby";
        myBook.Author = "F.Scott Fitzgerald";

        Console.WriteLine("Book Title: " + myBook.Title);
        Console.WriteLine("Book Author: " + myBook.Author);
    }
}
