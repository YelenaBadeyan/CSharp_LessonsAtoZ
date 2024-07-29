namespace PizzaFactories;

public class TypeFactory
{
    public static IType Get(string name)
    {
        switch (name.ToLower())
        {
            case "pepperoni":
                return new Pepperoni();
            case "salami":
                return new Salami();
            default:
                throw new ArgumentException();
        }
    }
}