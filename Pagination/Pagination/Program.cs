using System;


namespace Pagination
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            var customers = customerRepository.GetCustomerRepository();
            PaginationRequest<Person> result = new PaginationRequest<Person>(2, 1, customers, p => p.Id > 2);
            foreach (var customer in result)
            {
                Console.WriteLine(customer.Id);
            }
        }
    }
}