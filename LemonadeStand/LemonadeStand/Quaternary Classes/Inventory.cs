using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        
        Secondary_Classes.Lemon lemon;
        Tertiary_Classes.Ice ice;
        Secondary_Classes.Sugar sugar;
        private double price;

        public Inventory ()//constructor
        {
            this.ice = new Tertiary_Classes.Ice();
            this.lemon = new Secondary_Classes.Lemon();
            this.sugar = new Secondary_Classes.Sugar();
        }


        //public void AddStorePurchaseToInventory(Store store)
        //{
        //    //
        //}

        //} //public void GetInventory()
        //{
        //Console.WriteLine("The lemon inventory is: {0}", this.lemons);
        //Console.WriteLine("The sugar inventory is: {0}", this.sugar);
        //Console.WriteLine("The ice inventory is {0}", this.ice);
        //Console.WriteLine("Press Enter to Continue");
        //Console.ReadLine();
        //}

        //public void PrintInventoryStatus(Player player)
        //{

        //Console.WriteLine("Your Inventory Contains the following item quantities");
        //Console.WriteLine("Lemons:", inventory.PrintLemons);
        //Console.WriteLine("Sugar:", inventory.PrintSugar);
        //Console.WriteLine("Ice", inventory.PrintIce);
        //}

        //public void PrintLemons(LemonadeStandClass lemonadestand)
        //{
        //lemons = lemonadeStand.GetLemons
        //}
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


    }

}
     

