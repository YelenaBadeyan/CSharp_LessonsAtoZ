namespace Bookstore;

public class ShoppingCart
{
    private List<ConcreteBook> _books;

    public ShoppingCart()
    {
        _books = new List<ConcreteBook>();
    }

    public void AddBook(ConcreteBook book)
    {
        _books.Add(book);
    }

    public void RemoveBook(ConcreteBook book)
    {
        _books.Remove(book);
    }

    public List<ConcreteBook> GetBooks()
    {
        return _books;
    }

    public decimal GetTotalAmount()
    {
        return _books.Sum(b => b.Price);
    }

    public void Clear()
    {
        _books.Clear();
    }
}