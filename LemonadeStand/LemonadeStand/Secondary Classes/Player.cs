using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        private Cashbox cashbox;
        private LemonadeStand lemonadeStand;

        //Member Variables

        public Player() //constructor
        {
            this.lemonadeStand = new LemonadeStand();
            this.cashbox = new Cashbox();
        }

        public void TakeInCashbox(GamePlay.CashBox cashbox)
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
