namespace Bookstore;

public interface IUser
{
    string Name { get; set; }
    void ViewBooks(List<ConcreteBook> books);
}