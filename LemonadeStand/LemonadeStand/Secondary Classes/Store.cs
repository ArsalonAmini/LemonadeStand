using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        int result;

        public Store()
        {
            //constructor

        }

        //methods for taking in the player class 
        public void SellLemons (Player player) //method for taking in the player object 
        {
            Console.WriteLine("How many lemons?:");
            //result = Console.ReadLine();
            //return result;
            //player.RecieveCashBox.subtract(quantity * price);
        }

        public int SellSugar (Player player) //method for taking in the player object 
        {
            //Console.WriteLine("How many Sugars?:");
            //result = Console.ReadLine();
            //return result;
            //player.RecieveCashBox.subtract(quantity * price);
        }

        public void SellIce (Player player) //method for taking in the player object 
        {
            Console.WriteLine("How many Ices?:");
            //result = Console.ReadLine();
            //return result;
            //player.TakeInCashBox.GiveMoneyToStore(quantity * price);
        }

        //methods for taking in other objects
        public void CheckOut (Cashbox cashbox, Player player) //method for taking in the cashbox object
        {

            //cashbox.GiveMoneyToStore();
            //player.TakeInCashBox.GiveMoneyToStore(quantity * price);
            
        }

        public void TakeInInventory(Inventory inventory)
        {

        }
        
        public void TakeInLemon (Secondary_Classes.Lemon lemon)
        {

        }
        
        public void TakeInSugar (Secondary_Classes.Sugar sugar)
        {

        }
        
        public void TakeInIce (Tertiary_Classes.Ice ice)
        {

        }
    }
}
