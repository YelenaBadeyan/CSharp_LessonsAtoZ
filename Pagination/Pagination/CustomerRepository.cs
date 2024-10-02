using System.Text.Json;

namespace Pagination
{
    public class CustomerRepository
    {
        List<Person> customers = new List<Person>()
        {   
            new Person(1, "Yelena", 61, "345643443"),
            new Person(2, "Yelena", 61, "345643443"),
            new Person(3, "Karen", 83, "342341231"),
            new Person(4, "Arsen", 23, "456456534"),
            new Person(5, "Garik", 18, "743523234"),
            new Person(6, "Vahan", 45, "142342523"),
            new Person(7, "Karen", 25, "567453234"),
            new Person(8, "Hasmik", 16, "123242353"),
            new Person(9, "Ani", 61, "345643443"),
            new Person(10, "Lilith", 6, "342341231"),
            new Person(11, "Vache", 71, "456456534"),
            new Person(12, "Vahag", 20, "743523234"),
            new Person(13, "Anush", 26, "142342523"),
            new Person(14, "Mery", 51, "567453234"),
            new Person(15, "Jack", 14, "123242353")

        };

        public List<Person> GetCustomerRepository()
        {


            return customers;
        }
    }
}