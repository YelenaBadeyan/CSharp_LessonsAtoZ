namespace Bookstore;

public interface ICustomer : IUser
{
    void AddToCart(ConcreteBook book);
    void RemoveFromCart(ConcreteBook book);
    void PlaceOrder();
    void ViewOrderHistory();
}