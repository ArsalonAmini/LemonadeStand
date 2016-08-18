using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        int result;

        public Store()
        {
            //constructor
            Inventory inventory = new Inventory();

        }
        public void TakeInInventory(Inventory inventory)
        {
            //inventory.AddStorePurchaseToInventory();
        }

        //methods for taking in the player class 
        public int SellLemons (Player player) //method for taking in the player object 
        {
            Console.WriteLine("Welcome to your store, you can buy items here, specify the quantity of inventory");
            Console.WriteLine("How many lemons?:");
            result = Convert.ToInt32(Console.ReadLine());
            return result;
            //player.RecieveCashBox.subtract(quantity * price);
        }

        public int SellSugar (Player player) //method for taking in the player object 
        {
            Console.WriteLine("How many Sugars?:");
            result = Convert.ToInt32(Console.ReadLine());
            return result;
            //player.RecieveCashBox.subtract(quantity * price);
        }

        public int SellIce (Player player) //method for taking in the player object 
        {
            Console.WriteLine("How many Ices?:");
            result = Convert.ToInt32(Console.ReadLine());
            return result;
            //player.TakeInCashBox.GiveMoneyToStore(quantity * price);
        }

        //methods for taking in other objects
        public void CheckOut (CashBox cashBox, Player player) //method for taking in the cashbox object
        {

            //cashbox.GiveMoneyToStore();
            //player.TakeInCashBox.GiveMoneyToStore(quantity * price);
            
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
