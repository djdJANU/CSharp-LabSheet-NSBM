//5.	`Develop an application that simulates a library system. Create a class named LibraryBook with properties Title, Author, and Available. Implement a method BorrowBook that updates the availability status. Instantiate multiple book objects, perform book borrowing, and display the updated library status.

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LibraryBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; }

    public LibraryBook(string title,string author)
    {
        Title = title;
        Author = author;
        Available = true;
    }

    public void BorrowBook ()
    {
        if (Available)
        {
            Available = false;
            Console.WriteLine($"The Book '{Title}'by {Author} has been borrowed.");
        }
        else
        {
            Console.WriteLine($"The book '{Title}' by {Author} is currently not available.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<LibraryBook> books = new List<LibraryBook>()
        {
            new LibraryBook ("Book1" , "Author1"),
            new LibraryBook ("Book2" , "Author2"),
            new LibraryBook ("Book3" , "Author3")
        };

        // borrow a book
        Console.WriteLine("Borrowing a book___");
        books[0].BorrowBook();

        // Display library statues
        Console.WriteLine("\nUpdated Library statues");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available: {book.Available}");
        }
    }
}