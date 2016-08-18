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
        
       

        public Customer() //constructor
        {
            this.random = new Random();
        }

        public void ChooseLemonadeType()
        {
            int customerChoice = random.Next(0, 2);

            if (customerChoice == 1)
            {
                //recipe is tart (3 lemons, 1 sugar, 1 ice)
                //recipeActOnInventory
                //InventoryActOnPlayer
                //PlayerActOnCashBox
            }
            else if (customerChoice == 2)
            {
                //recipe is sweet (3 lemons, 3 sugars, 1 ice)
            }
            else
            {
                //recipe is normal (3 lemons, 2 sugars, 2 ice)
            }
        }

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

