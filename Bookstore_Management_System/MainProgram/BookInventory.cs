namespace Bookstore;

public class BookInventory
{
    private List<ConcreteBook> _books;

    public BookInventory()
    {
        _books = new List<ConcreteBook>();
    }

    public void AddBook(ConcreteBook book)
    {
        _books.Add(book);
    }

    public void UpdateBook(ConcreteBook book)
    {

        var existingBook = _books.FirstOrDefault(b => b.ISBN == book.ISBN);
        if (existingBook != null)
        {
            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Price = book.Price;
            existingBook.StockQuantity = book.StockQuantity;
            existingBook.Description = book.Description;
            existingBook.Category = book.Category;
        }
    }

    
    
    //TODO..CHANGERETURNTYPE

    public void DeleteBook(string isbn) 
    {
        var bookToRemove = _books.FirstOrDefault(b => b.ISBN == isbn);
        if (bookToRemove != null)
        {
            _books.Remove(bookToRemove);
        }
    }

    public List<ConcreteBook> GetBooks()
    {
        return _books;
    }
}