using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {

        public Store()
        {
            //constructor
        }


        //methods for taking in the player class 
        public void SellLemons (Player player) //method for taking in the player object 
        {
            Console.WriteLine("How many lemons?:");
            //player.RecieveCashBox.subtract(quantity * price);
        }

        public void SellSugar (Player player) //method for taking in the player object 
        {
            Console.WriteLine("How many Sugars?:");
            //player.RecieveCashBox.subtract(quantity * price);
        }


        public void SellIce (Player player) //method for taking in the player object 
        {
            Console.WriteLine("How many Ices?:");
            //player.RecieveCashBox.subtract(quantity * price);
        }


        //methods for taking in other objects
        public void CheckOut (Cashbox cashbox) //method for taking in the cashbox object
        {
            cashbox.PlayerCheckOut();
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
