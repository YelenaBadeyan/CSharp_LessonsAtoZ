namespace Bookstore;

public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public List<ConcreteBook> Books { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }

    public Order(int orderId, string customerName, List<ConcreteBook> books)
    {
        OrderId = orderId;
        CustomerName = customerName;
        Books = books;
        OrderDate = DateTime.Now;
        TotalAmount = books.Sum(b => b.Price);
    }
}