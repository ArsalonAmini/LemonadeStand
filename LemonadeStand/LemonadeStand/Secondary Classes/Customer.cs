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

        public Customer() //constructor
        {
            this.random = new Random();
        }

        public List<Customer> CalculateCustomerPreference(List<Customer> potentialCustomers) //verified by A.Amini-Hajibashi, built on 8/20/2016
        {
            foreach (Customer customer in potentialCustomers) 
            {
                customer.customerPreference = random.Next(1, 4);
            }
            return potentialCustomers;
        }

        

        }
    }





