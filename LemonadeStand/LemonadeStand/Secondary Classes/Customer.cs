using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        Random random;
        public int customerPreference;
        public List<Customer> potentialCustomers;
        public int customerSweet;
        public int customerTart;
        public int customerRegular;

        public Customer() //constructor
        {
            this.random = new Random();
        }


        public void MakeCustomerBuyLemonade(List<Customer> potentialCustomers) //tested and verifed by A.Amini-Hajibashi  8/22/2016
        {
            foreach (Customer customer in potentialCustomers)
            {
                if (customer.customerPreference == 1)
                {
                    customer.customerSweet = 1;
                    Console.WriteLine("Customer bought sweet lemonade!");
                    //return potentialCustomers;
                }
                else if (customer.customerPreference == 2)
                {
                    customer.customerTart = 1;
                    Console.WriteLine("Customer bought a tart lemonade!");
                }
                else if (customer.customerPreference == 3)
                {
                    customer.customerRegular = 1;
                    Console.WriteLine("Customer did not buy lemonade!");
                }
                else
                {
                    customer.customerRegular = 1;
                    Console.WriteLine("Customer didn't buy lemonade!");
                }
            }
        }

        public List<Customer> CalculateCustomerPreference(List<Customer> potentialCustomers) //tested & verified by A.Amini-Hajibashi on 8/20/2016
        {
            foreach (Customer customer in potentialCustomers)
            {
                customer.customerPreference = random.Next(1, 4);
            }
            return potentialCustomers;
        }

    }

}







