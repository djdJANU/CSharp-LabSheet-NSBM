//4.	Construct a C# program for a basic inventory system. Define a class named Product with properties ProductName and Price. Implement a parameterized constructor to initialize these properties. Instantiate objects using the constructor and display the product details.

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }

    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //instantiate products
        Product product1 = new Product("Laptop", 899.99);
        Product product2 = new Product("Smartphone", 599.99);
        Product product3 = new Product("headphones", 79.99);

        //Display product details
        Console.WriteLine("Product Details:");
        Console.WriteLine($"Product Name: {product1.ProductName}, Price: ${product1.Price}");
        Console.WriteLine($"Product Name: {product2.ProductName}, Price: ${product2.Price}");
        Console.WriteLine($"Product Name: {product3.ProductName}, Price: ${product3.Price}");
    }
}