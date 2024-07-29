namespace PizzaFactories;

public class Salami : IType
{
    public string Prepare()
    {
        return "Salami";
    }

    public int Cost()
    {
        return 7;
    }
}