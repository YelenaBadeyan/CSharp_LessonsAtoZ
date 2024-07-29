namespace PizzaFactories;

public class ThickDough : IDough
{
    public string Bake()
    {
        return "Thick dough";
    }

    public int Cost()
    {
        return 2;
    }
}