namespace PizzaFactories;

public class ThinDough : IDough
{
    public string Bake()
    {
        return "Thin dough";
    }

    public int Cost()
    {
        return 1;
    }
}