using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {

        static void Main(string[] args)
        {

            Primary_Classes.TestClass testClass = new Primary_Classes.TestClass();
            //Game game = new Game();
            //game.NewGame();
            //game.RunGame();
            //Console.ReadLine();

            int numberOfPotentialCustomers = 100;
            CashBox cashBox = new CashBox();

            List<Customer> potentialCustomers = new List<Customer>();
            for (int i = 0; i < numberOfPotentialCustomers; i++)
            {
                Customer customer = new Customer();
                potentialCustomers.Add(new Customer());
            }
            testClass.GeneratePotentialCustomers(numberOfPotentialCustomers);
            testClass.CalculateCustomerPreference(potentialCustomers); //how to call a member variable <list> into a new function
            testClass.MakeCustomerBuyLemonade(potentialCustomers);
            testClass.AddSaleToCashBox(potentialCustomers, cashBox);
        }
    
    }
}

   

