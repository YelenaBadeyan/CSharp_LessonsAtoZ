namespace PizzaFactories;

public class AmericanDough : IDough
{
    public string Bake()
    {
        return "American dough";
    }

    public int Cost()
    {
        return 5;
    }
}