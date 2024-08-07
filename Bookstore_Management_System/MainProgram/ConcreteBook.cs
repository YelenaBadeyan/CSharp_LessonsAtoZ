namespace Bookstore;

public class ConcreteBook : Book
{
    public ConcreteBook(string title, string author, string isbn, decimal price, int stockQuantity, string description, string category)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Price = price;
        StockQuantity = stockQuantity;
        Description = description;
        Category = category;
    }
}