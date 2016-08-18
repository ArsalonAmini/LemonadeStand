using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        private CashBox cashBox;
        private LemonadeStandClass lemonadeStand;
        int lemonadePrice;
        int boughtLemons;
        public int cashSpent;

        public Player() //constructor
        {
            this.lemonadeStand = new LemonadeStandClass();
            this.cashBox = new CashBox();
        }
        //public int BuyLemons(CashBox cashbox)
        //{
        //    Console.WriteLine("Welcome to your store, you can buy items here, specify the quantity of inventory");
        //    Console.WriteLine("How many lemons at $1/each?:");
        //    boughtLemons = Convert.ToInt32(Console.ReadLine());
        //    cashSpent = (boughtLemons * 1);
        //    cashbox.debit(cashSpent);
        //    //player.RecieveCashBox.subtract(quantity * price);
        //}

        public int SetLemonadePrice(Price price)
        {
            Console.WriteLine("How much would you like to sell your Lemonade for today?");
            lemonadePrice = Convert.ToInt32(Console.ReadLine());
            return lemonadePrice;
        }
        
        public void BuySugar(Store store)
        {
            //TakeInStore object
        }

        public void BuyIce(Store store)
        {
            //TakeInStore object
        }
        public void GetPlayerCashbox(CashBox cashbox)
        {

            //cashBox = cashBox.GiveMoneyToStore() + cashBox.GetMoneyFromCustomer()
            //return cashBox;
            //cashbox.GetPlayerBalance();
        }
    }
}
