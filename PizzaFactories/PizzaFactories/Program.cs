using System;

namespace PizzaFactories
{
    class PizzaFactory
    {
        private IDough _dough;
        private List<IType> _type;
        private List<ITopping> _topping;
        private const int Baseprice = 10;
        public PizzaFactory(IDough dough)
        {
            _dough = dough;
            _type = new List<IType>();
            _topping = new List<ITopping>();
        }

        public PizzaFactory addType(IType type)
        {
            _type.Add(type);
            return this;
        }

        public PizzaFactory addTopping(ITopping topping)
        {
            _topping.Add(topping);
            return this;
        }

        public string Make()
        {
            string result = $"Your pizza is ready. The dough is {_dough.Bake()}.\n";

            if (_type.Count == 0)
            {
                throw new ArgumentException();
            }
            result +=
                $"Type{(_type.Count == 1 ? " is" : "s are")} {string.Join(", ", _type.Select(t => t.Prepare()))}\n";

            if (_topping.Count == 0)
            {
                result += "There is no topping for this pizza";
                
            }
            else
            {
                result +=
                    $"Topping{(_topping.Count == 1 ? " is" : "s are")} {string.Join(", ", _topping.Select(t => t.Put()))}";
            }

            return result;
        }

        public static string GetAcceptableValues(Type type)
        {

            return string.Join(", ", AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p != type)
                .Select(x => x.Name));

        }

        public int CalculateCost()
        {
            
            return Baseprice + _dough.Cost() 
                + _type.Select(t => t.Cost()).Sum() 
                + _topping.Select(t => t.Cost()).Sum();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please select your preferred dough type.\n" +
                              $"The existing options are: {GetAcceptableValues(typeof(IDough))}" );

            Object? o = Activator.CreateInstance(null);
            Console.WriteLine(((IDough)Activator.CreateInstance(typeof(AmericanDough))).Bake());


            var pf = new PizzaFactory(
                DoughFactory.Get("American"));
            pf.addType(TypeFactory.Get("pepperoni"))
                .addType(TypeFactory.Get("salami"))
                .addTopping(ToppingFactory.Get("ketchup"))
                .addTopping(ToppingFactory.Get("cheese"));
            Console.WriteLine(pf.Make());
            Console.WriteLine(pf.CalculateCost());


        }
    }
}

