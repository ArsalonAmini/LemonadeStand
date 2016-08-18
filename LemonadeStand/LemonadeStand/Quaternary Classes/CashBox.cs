using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class CashBox 
    {
        private int moneyFromCustomer;

        public void Cashbox()
            {
                //constructor
            }
        public void AddPlayerMoney(CashBox cashBox)
        {
            //
        }

        public void PrintPlayerMoney (Player player)
        {
            Console.WriteLine("Your CashBox contains the following");
            Console.WriteLine("You have {0} money in your cashbox", player.GetPlayerCashbox);
            //playerMoney - moneyToStore + moneyFromCustomer

        }
        public void GiveMoneyToStore (Store store)
        {
            //act on store method
            //return moneyToStore
        }

        public int GetMoneyFromCustomer (Customer customer)
        {
            //CustomerRecipe * Price Lemon + CustomerRecipe * Price 
            moneyFromCustomer = Convert.ToInt32(Console.ReadLine());
            return moneyFromCustomer;
        }
        public void CheckOut(Player player)
        {
            //check player cashBox member variable to see if enough money
            //if enough money
            //subtract playercheckout local variable from cashbox member variable
        }
    }
}

