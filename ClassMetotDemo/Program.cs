using System;

namespace ClassMetotDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Liste(customer);
            customerManager.Remove();
        }
    }
}
