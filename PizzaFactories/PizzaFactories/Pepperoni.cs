namespace PizzaFactories;

public class Pepperoni : IType
{
    public string Prepare()
    {
        return "Pepperoni";
    }

    public int Cost()
    {
        return 3;
    }
}