namespace PizzaFactories;

public class Ketchup : ITopping
{

    public string Put()
    {
        return "Ketchup";
    }

    public int Cost()
    {
        return 6;
    }
}