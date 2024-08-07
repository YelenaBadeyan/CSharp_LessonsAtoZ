namespace Bookstore;

public class Admin : IAdmin
{
    public string Name { get; set; }
    private BookInventory _inventory;

    public Admin(string name, BookInventory inventory)
    {
        Name = name;
        _inventory = inventory;
    }

    public void ViewBooks(List<ConcreteBook> books)
    {
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} by {book.Author} - ${book.Price}");
        }
    }

    public void AddBook(ConcreteBook book)
    {
        _inventory.AddBook(book);
    }

    public void UpdateBook(ConcreteBook book)
    {
        _inventory.UpdateBook(book);
    }

    public void DeleteBook(string isbn)
    {
        _inventory.DeleteBook(isbn);
    }

}