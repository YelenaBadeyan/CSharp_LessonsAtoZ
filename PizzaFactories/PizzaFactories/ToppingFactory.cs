namespace PizzaFactories;

public class ToppingFactory
{
    public static ITopping Get(string name)
    {
        switch (name.ToLower())
        {
            case "cheese":
                return new Cheese();
            case "ketchup":
                return new Ketchup();
            default:
                throw new ArgumentException();
        }
    }
       
}