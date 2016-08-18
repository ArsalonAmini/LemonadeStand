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
        private int lemonadePrice;
        private int boughtLemons;
       

        //Member Variables

        public Player() //constructor
        {
            this.lemonadeStand = new LemonadeStandClass();
            this.cashBox = new CashBox();
        }

        public void GetPlayerCashbox(CashBox cashbox)
        {

            //cashBox = cashBox.GiveMoneyToStore() + cashBox.GetMoneyFromCustomer()
            //return cashBox;
            //cashbox.GetPlayerBalance();
        }

        public int SetLemonadePrice(Price price)
        {
            Console.WriteLine("How much would you like to sell your Lemonade for today?");
            lemonadePrice = Convert.ToInt32(Console.ReadLine());
            return lemonadePrice;
        }
        

        public int BuyLemons (Store store)
        {
            Console.WriteLine("Welcome to your store, you can buy items here, specify the quantity of inventory");
            Console.WriteLine("How many lemons?:");
            boughtLemons = Convert.ToInt32(Console.ReadLine());
            return boughtLemons;
            ////player.RecieveCashBox.subtract(quantity * price);
        }

        public void BuySugar(Store store)
        {
            //TakeInStore object
        }

        public void BuyIce(Store store)
        {
            //TakeInStore object
        }

    }
}
