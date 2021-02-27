using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine(customer.Name + " Added!");

        }
        public void Delete(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine(customer.Name + " Deleted!");
        }
        public void List()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer Id : " + customer.Id + " Customer Name : " + customer.Name);
                Console.WriteLine("***********");
            }
        }
    }
}
