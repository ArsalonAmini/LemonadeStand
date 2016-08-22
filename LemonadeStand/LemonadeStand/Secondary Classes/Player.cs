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
        public double lemonadePrice;
        double boughtLemons;
        public double cashSpent;
        private double boughtSugar;
        private double boughtIce;

        public Player() //constructor
        {
            this.lemonadeStand = new LemonadeStandClass();
            this.cashBox = new CashBox();
        }

        public double SetLemonadePrice() //Tested and verified by A Amini-Hajibashi 8/19/2016 //modifeid and retested on 8/19/2016
        {
            Console.WriteLine("How much would you like to sell your Lemonade for today?");
            lemonadePrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Today's selling price is: ${0}", lemonadePrice);
            return lemonadePrice;
        }

        public double BuyLemons() //Tested and verified by A Amini-Hajibashi 8/19/2016 //modified and retested to include cashbox.debit method and return statement
        {
            Console.WriteLine("How many Lemons at $1.75/each?:");
            boughtLemons = Convert.ToDouble(Console.ReadLine());
            cashSpent = Convert.ToDouble((boughtLemons * 0.75));
            Console.WriteLine("You have spent:${0}", cashSpent);
            Console.WriteLine("You have a remaining cash balance of ${0}", cashBox.Debit(cashSpent));
            return boughtLemons;
        }

        public double BuySugar() //tested and verified by A Amini-Hajibashi 8/19/2016
        {
            Console.WriteLine("How many sugars at $0.75/each?:");
            boughtSugar = Convert.ToDouble(Console.ReadLine());
            cashSpent = Convert.ToDouble((boughtSugar * 1.25));
            Console.WriteLine("You have spent:${0}", cashSpent);
            Console.WriteLine("You have a remaining cash balance of ${0}", cashBox.Debit(cashSpent));
            return boughtSugar; ;
        }

        public double BuyIce() //tested and verified by A Amini-Hajibashi on 8/19/2016
        {
            Console.WriteLine("How many Ices at $0.10/each?:");
            boughtIce = Convert.ToDouble(Console.ReadLine());
            cashSpent = Convert.ToDouble((boughtIce * 0.75));
            Console.WriteLine("You have spent:${0}", cashSpent);
            Console.WriteLine("You have a remaining cash balance of ${0}", cashBox.Debit(cashSpent));
            return boughtIce;
        }

        public void GetPlayerCashbox(CashBox cashbox)
        {

            //cashBox = cashBox.GiveMoneyToStore() + cashBox.GetMoneyFromCustomer()
            //return cashBox;
            //cashbox.GetPlayerBalance();
        }
    }
}


