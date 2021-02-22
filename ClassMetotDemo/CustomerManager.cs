using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void Add(Customer customer)
        {
            customer.Id = 1;
            customer.Name = "Eren";
            customer.Surname = "Kut";
            customer.BirthYear = 2001;
            Console.WriteLine("Müşteri eklendi");

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Resul";
            customer2.Surname = "Emre";
            customer2.BirthYear = 2001;
            Console.WriteLine("Müşteri eklendi");
        }
        public void Liste(Customer customer)
        {
            Console.WriteLine("Musteri Id: " + customer.Id);
            Console.WriteLine("Musteri Adı: " + customer.Name);
            Console.WriteLine("Musteri Soyadi: " + customer.Surname);
            Console.WriteLine("Musteri DogumYili: " + customer.BirthYear);
        }

        public void Remove()
        {
            Console.WriteLine("Müşteri silindi");
        }  
    }
}
