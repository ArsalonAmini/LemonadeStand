using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Primary_Classes
{
    class TestClass
    {
        Customer customer;
        Random random;
        private int customerPreference;

        public TestClass()
        {
            this.customer = new Customer();
            this.random = new Random();
        }

        public List<Customer> GeneratePotentialCustomers(int numberOfPotentialCustomers) //Verified and Tested by A Amini-Hajibashi

        {
            List<Customer> potentialCustomers = new List<Customer>();
            for (int i = 0; i < numberOfPotentialCustomers; i++)
            {
                Customer customer = new Customer();
                potentialCustomers.Add(new Customer());
            }
            return potentialCustomers;

        }

        public List<Customer> CalculateCustomerPreference(List<Customer> potentialCustomers) //verified by A.Amini-Hajibashi, built on 8/20/2016
        {
            foreach (Customer customer in potentialCustomers) //does this function gen a list of objects with customer preference attribute??
            {
                customer.customerPreference = random.Next(1, 4);
            }
            return potentialCustomers;
        }

        public void MakeCustomerBuyLemonade(List<Customer> potentialCustomers) //tested and verifed by A.Amini-Hajibashi  8/22/2016
        {
            foreach (Customer customer in potentialCustomers)
            {
                if (customer.customerPreference == 1)
                {
                    //recipe for sweet
                    Console.WriteLine("Customer bought sweet lemonade!");
                    //return potentialCustomers;
                }
                else if (customer.customerPreference == 2)
                {
                    //recipe tart
                    //tartRecipe.MakeLemonade();
                    Console.WriteLine("Customer bought a tart lemonade!");
                    //return potentialCustomers;
                }
                else if (customer.customerPreference == 3)
                {
                    Console.WriteLine("Customer did not buy lemonade!");
                }
                else
                {
                    //recipe for normal
                    //recipe.MakeLemonade();
                    Console.WriteLine("Customer didn't buy lemonade!");
                    //return potentialCustomers;
                }
            }
        }
    }
  }

