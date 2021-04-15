using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    Name = "Oğuzhan",
            //    LastName = "Mollaoğlu",
            //    IdentityNo = "12123533256",
            //    CustomerNo = "12345",
            //    CompanyName = "?"
            //};

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            //Oğuzhan Mollaoğlu
            RealCustomer realCustomer = new RealCustomer
            {
                Id = 1,
                CustomerNo = "12345",
                Name = "Oğuzhan",
                LastName = "Mollaoğlu",
                IdentityNo = "12343245676"
            };
            
            //Kodlama.io

            CoorporateCustomer coorporateCustomer = new CoorporateCustomer
            {
                Id = 2,
                CompanyName = "Kodlama.io",
                TaxNo = "123456789"
            };

            // müşteri hem gerçek hem tüzel müşteri olabiliyor 
            // new lenmek demek o nesnenin referans no'sudur.  
            Customer customer1 = new RealCustomer();
            Customer customer2 = new CoorporateCustomer();


            // görüldüğü üzere tek bir ekleme methodu ile ikisinde ekleyebildik
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
