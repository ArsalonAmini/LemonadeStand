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
        private int customerPreference;

        public Customer() //constructor
        {
            this.random = new Random();
        }

       
        //public List<Customer> AddCustomerToDailyCustomers(List<Customer> dailyCustomers, Customer customer)
        // {
        //     int numberOfPotentialCustomer = 100;

        //     for (int i = 0; i < numberOfPotentialCustomer; i++)
        //     {
        //         dailyCustomers.Add(customer);
        //     }
        //     return dailyCustomers;
        // }


        public void BuyLemonade() //buying loop
        {
            int buyLemonade = random.Next(0, 2);

                if (buyLemonade == 1) 
            {
                Console.WriteLine("Customer bought lemonade");
                //actOnCashbox (player method)
                //actOnInventor (Lemonade Stand, Recipe method)
            }
            else if (buyLemonade == 2)
            {
                Console.WriteLine("Customer did not buy lemonade");
            }
            else
            {
                Console.WriteLine("No customers, showed up today!");
            }
        }

       
        //public void Displaycustomers(List<Customer> customerList)
        //{
        //    foreach (Customer customer in customerList)
        //    {
        //        Console.WriteLine(customer.ChooseLemonadeType + "Buy/No Buy " + customer.BuyLemonade);
        //    }
        //}
    }
}

