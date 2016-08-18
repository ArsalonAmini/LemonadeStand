using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        int lemons;
        int sugar;
        int ice;

        public Inventory ()//constructor
        {
             lemons = 1;
             sugar = 1;
             ice = 1;
        }


        public void GetInventory()
        {
        Console.WriteLine("The lemon inventory is: {0}", this.lemons);
        Console.WriteLine("The sugar inventory is: {0}", this.sugar);
        Console.WriteLine("The ice inventory is {0}", this.ice);
        Console.ReadLine();
        }

        public void AddStorePurchaseToInventory(Store store)
        {
            //
        }


        public void PrintInventoryStatus(Player player)
        {

            //Console.WriteLine("Your Inventory Contains the following item quantities");
            //Console.WriteLine("Lemons:", inventory.PrintLemons);
            //Console.WriteLine("Sugar:", inventory.PrintSugar);
            //Console.WriteLine("Ice", inventory.PrintIce);
        }

        public void PrintLemons(LemonadeStandClass lemonadestand)
        {
            //lemons = lemonadeStand.GetLemons
        }
        //public void AddInventory(CashBox cashbox, Store store)
        //{
        //lemons = 0;
        //sugar = 0;
        //ice = 0;

            //while (player.Cashbox > 0, i++)
            //{
            //    lemonInventory = lemons + playerBuyLemons;
            //    sugarInventory = sugar + playerBuySugar;
            //    iceInventory = ice + playerBuyIce;
            //    CashBox.
            //    i++;
            //}


        public void MakeLemonade (Tertiary_Classes.Recipe recipe)
        {
            //recipe object
            //lemonadeFormala = (3*lemons) + (1*sugar) + (4*ice) //member variables from the store class inserted in 
            //Lemon = Lemon - 3; //lemon variable in inventory reduced by 3 return to player
            //Sugar = sugar - 1;// sugar variable in inventory reduced by 3 return to player
            //Ice = Ice - 4;// ice variable in inventory reduced by 3 return to player
            //return Lemon, sugar, ice
            //Player.Profit += 1 //add 1 lemonade multiplier to profit variable on player object 

        }

        public void TakeInLemon(Secondary_Classes.Lemon lemon)
        {
            //lemon object
        }

        public void TakeInSugar(Secondary_Classes.Sugar sugar)
        {
            //sugar object
        }

        public void TakeInIce(Tertiary_Classes.Ice ice)
        {
            //ice object
        }
}

}
     

