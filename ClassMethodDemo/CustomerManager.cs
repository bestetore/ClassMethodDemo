using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();

      public void Add(Customer customer)
      {
            customers.Add(customer);
            Console.WriteLine(customer.FirstName + " " +customer.LastName +" " + "Added!");
      }

      public void Delete(Customer customer)
      {
            customers.Remove(customer);
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + "Deleted!");
      }


        public void List() 
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id +" "+ customer.FirstName +" "+ customer.LastName +" "+ customer.EMail);
            }
        }

     



    }
}
