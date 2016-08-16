using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //Member Variables

        public Player(CashBox cashbox, LemonadeStand lemonadeStand) //constructor
        {
            this.lemonadeStand = new LemonadeStand();
            this.cashbox = new Cashbox();
        }

        public void TakeInCashbox (CashBox cashbox)
        {
            //cashBox Object //call CashBox reciprocal method (player method)
        }

        public void TakeInLemonadeStand(LemonadeStand lemonadeStand)
        {
            //lemonadeStand object
        }
 
    }
