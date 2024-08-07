namespace Bookstore;

public interface IAdmin : IUser
{
    void AddBook(ConcreteBook book);
    void UpdateBook(ConcreteBook book);
    void DeleteBook(string isbn);
}