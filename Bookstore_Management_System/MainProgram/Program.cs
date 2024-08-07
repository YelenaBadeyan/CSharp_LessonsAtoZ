using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookstore
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new BookInventory();
            var admin = new Admin("Admin", inventory);
            var customer = new Customer("John Doe");

            // Add some books to the inventory
            Console.WriteLine("Admin adding books to the inventory...");
            admin.AddBook(new ConcreteBook("Book 1", "Author 1", "123", 10.99m, 5, "Description 1", "Fiction"));
            admin.AddBook(new ConcreteBook("Book 2", "Author 2", "456", 15.99m, 3, "Description 2", "Non-Fiction"));

            // Customer views books and adds to cart
            Console.WriteLine("\nCustomer viewing available books...");
            customer.ViewBooks(inventory.GetBooks());
            var books = inventory.GetBooks();
            Console.WriteLine("\nCustomer adding 'Book 1' to the cart...");
            customer.AddToCart(books[0]);

            // Customer places an order
            Console.WriteLine("\nCustomer placing an order...");
            customer.PlaceOrder();
            Console.WriteLine("\nCustomer viewing order history...");
            customer.ViewOrderHistory();

            // Admin manages the inventory
            Console.WriteLine("\nAdmin updating 'Book 1' in the inventory...");
            admin.UpdateBook(new ConcreteBook("Updated Book 1", "Author 1", "123", 12.99m, 10, "Updated Description 1",
                "Fiction"));
            Console.WriteLine("\nAdmin deleting 'Book 2' from the inventory...");
            admin.DeleteBook("456");

            Console.WriteLine("\nFinal list of books in the inventory:");
            customer.ViewBooks(inventory.GetBooks());
        }
    }
}