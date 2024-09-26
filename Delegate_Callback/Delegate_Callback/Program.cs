using System;
using System.Linq;

namespace Delegate_Callback
{
    public delegate void MyDelegate(bool ifCardOrdered);
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Yelena", "6758484");

            BankingSystem myBank = new BankingSystem();
            myBank.AddCustomer(person);
            var isCustomer = myBank.IsCustomer(person);
            Console.WriteLine($"Is Customer: {isCustomer} ");

            myBank.OrderCard(person, SendNotificationViaSMS);

             void SendNotificationViaSMS(bool ifCardOrdered)
            {
                if (ifCardOrdered)
                {
                    Console.WriteLine("Your card is ordered successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to order the card.");
                }
            }

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string SSN { get; set; }

        public Person(string name, string SSN)
        {
            Name = name;
            this.SSN = SSN;
            
        }

    }

    public class BankingSystem
    {
        List<Person> customers { get; set; } = new List<Person>();

        public void AddCustomer(Person person)
        {
            customers.Add(person);
        }

        public bool IsCustomer(Person person)
        {
            //var result = customers.Any(person => person.SSN == person.SSN);
            //Console.WriteLine(customers.Any(person => person.SSN == person.Name));
            return customers.Any(person => person.SSN == person.SSN);

        }  



        public void OrderCard(Person person, MyDelegate callback)
        {
            if (IsCustomer(person))
            {
                Console.WriteLine("Ordering a card...");
                Thread.Sleep(5000);  
                Console.WriteLine("Card is ordered.");
                callback(true);  
            }
            else
            {
                Console.WriteLine("Person is not a customer.");
                callback(false); 
            }
        }
            
        
    }


    
}