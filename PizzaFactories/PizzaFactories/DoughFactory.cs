namespace PizzaFactories;

public class DoughFactory
{
    public static IDough Get(string dough)
    {
        switch (dough.ToLower())
        {
            case "thin":
                return new ThinDough();
            case "thick":
                return new ThickDough();
            case "american":
                return new AmericanDough();
            default: 
                throw new ArgumentException();
        }
    } 
}