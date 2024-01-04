using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi : " + customer.FirstName + " " + customer.LastName);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi : " + customer.FirstName + " " + customer.LastName);

        }
        public void GetList(Customer[] customers)
        {
            Console.WriteLine("Mevcut müşteriler :");
            foreach (Customer customer in customers) 
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName);
            }
        }

    }
}
