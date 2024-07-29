namespace PizzaFactories;

public class Cheese : ITopping
{
    public string Put()
    {
        return "Cheese";
    }

    public int Cost()
    {
        return 4;
    }
}