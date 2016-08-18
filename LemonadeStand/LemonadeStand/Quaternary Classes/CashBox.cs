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
        private int balance;
       
       

        public CashBox()
            {
            //constructor
            balance = 1;

            }
        public void PrintBalance()
        {
            Console.WriteLine("Your CashBox contains the following");
            Console.WriteLine("You have {0} money in your cashbox", balance);
        }

        
        public int Debit(int cashSpent)
        {
            balance = balance - cashSpent;
            return balance;
        }

        //public int AddPlayerMoney(CashBox cashBox)
        //{
        //    //
        //    return balance;
        //}


        //public void GiveMoneyToStore (Store store)
        //{
        //    //act on store method
        //    //return moneyToStore
        //}

        //public int GetMoneyFromCustomer (Customer customer)
        //{
        //    //CustomerRecipe * Price Lemon + CustomerRecipe * Price 
        //    moneyFromCustomer = Convert.ToInt32(Console.ReadLine());
        //    return moneyFromCustomer;
        //}

    }
}

