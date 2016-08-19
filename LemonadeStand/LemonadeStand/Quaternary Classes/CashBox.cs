using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class CashBox 
    {
        //private double moneyFromCustomer;
        private double balance;
       
       

        public CashBox()
            {
            //constructor
            balance = 100;

            }
        public void PrintBalance() //tested and verified 8/18/2016
        {
            Console.WriteLine("Your Cashbox contains the following");
            Console.WriteLine("You have ${0} in your cashbox", balance);
        }

        
        public double Debit(double cashSpent) //tested and verified 8/18/2016
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

