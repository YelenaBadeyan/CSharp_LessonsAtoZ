namespace Bookstore;

public class Customer : ICustomer
{
    public string Name { get; set; }
    private List<ConcreteBook> _shoppingCart;
    private List<Order> _orderHistory;

    public Customer(string name)
    {
        Name = name;
        _shoppingCart = new List<ConcreteBook>();
        _orderHistory = new List<Order>();
    }


    public void AddToCart(ConcreteBook book)
    {
        _shoppingCart.Add(book);
    }

    public void PlaceOrder()
    {
        if (_shoppingCart.Count > 0)
        {
            var orderId = _orderHistory.Count + 1;
            var order = new Order(orderId, Name, _shoppingCart);
            _orderHistory.Add(order);
            _shoppingCart.Clear();
            Console.WriteLine($"Order {orderId} placed successfully. Total amount: ${order.TotalAmount}");
            
            Console.WriteLine($"Order confirmation email sent to {Name}.");
        }
        else
        {
            Console.WriteLine("Shopping cart is empty. Add books to the cart before placing an order.");
        }
    }

    public void RemoveFromCart(ConcreteBook book)
    {
        _shoppingCart.Remove(book);
    }

    public void ViewOrderHistory()
    {
        if (_orderHistory.Count > 0)
        {
            foreach (var order in _orderHistory)
            {
                Console.WriteLine($"Order {order.OrderId} placed on {order.OrderDate} with total amount ${order.TotalAmount}");
            }
        }
        else
        {
            Console.WriteLine("No orders placed yet.");
        }
    }


    public void ViewBooks(List<ConcreteBook> books)
    {
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} by {book.Author} - ${book.Price}");
        }
    }
}
