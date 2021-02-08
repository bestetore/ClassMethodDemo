using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Betül";
            customer1.LastName = "Yılmaz";
            customer1.ContactNumber = "05*******";
            customer1.EMail = "betul.yilmaz@outlook.com";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Ayşe";
            customer2.LastName = "Güngör";
            customer2.ContactNumber = "05*******";
            customer2.EMail = "ayse.gungor@outlook.com";



            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.List();


            customerManager.Delete(customer2);
            customerManager.List();





        }
    }

   
}
