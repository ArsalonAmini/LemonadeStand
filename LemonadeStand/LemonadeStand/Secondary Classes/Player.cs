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

        //Member Variables

        public Player() //constructor
        {
            this.lemonadeStand = new LemonadeStandClass();
            this.cashBox = new CashBox();
        }

        public void TakeInCashbox(CashBox cashbox)
        {
            //cashBox Object //call CashBox reciprocal method (player method)
            //cashbox.GetPlayerBalance();
        }

        public void BuyLemons (Store store)
        {
            //TakeInStore object
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
