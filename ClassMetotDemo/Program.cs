using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Mine Aktaş";
            customer1.Job = "Software Developer";
            customer1.Age = 22;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Ahmet Aktaş";
            customer2.Job = "Dentist";
            customer2.Age = 20;


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.List();

            customerManager.Delete(customer2);
            customerManager.List();
        }
    }
}
