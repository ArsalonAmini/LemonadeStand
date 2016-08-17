using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player player = new Player();
        Weather weather = new Weather();
        Customer customer = new Customer();
        Day day = new Day();
        Store store = new Store();
        int numberOfDays;

        public void NewGame()
        {
            Console.WriteLine("Welcome to A.Amini-Hajibashi's Lemonade Stand game");
            Console.WriteLine("The Rules are pretty Basic, for your convienience, Player");
            Console.WriteLine("Purchase Inventory from the Store");
            Console.WriteLine("SellLemonade to customer");
            Console.WriteLine("Rain or Shine try making your dime!");
            Console.ReadLine();
            numberOfDays = 0;
        }
        public void RunGame()
        {

            while (numberOfDays < 7)
            {
                //Inventory.GetStatus(player) //InventoryActsOnPlayer
                //CashBox.GetPlayerMoney (player) //CashBoxActsOnPlayer
                //Store.SellLemons(player) //StoreActsOnPlayer
                //Store.SellSugar(player) //StoreActsOnPlayer
                //Store.SellIce(player) //StoreActsOnPlayer
                //Player.BuyLemons(store) //PlayerActsOnStore
                //Player.BuySugar(store) //PlayerActsOnStore
                //Player.BuyIce(store) //PlayerActsOnStore
                //Inventory.GetInventoryStatus(player) //InventoryActsOnPlayer(GetInventory)
                //Player.SetPrice(price)  //PlayerActsOnPrice 
                //Weather.GetWeather(demand) //WeatherActsOnDemand
                //Price.GetPrice(demand) //PriceActsOnDemand
                //Demand.GetBuyerChance (customer) //DemandActsOnCustomer
                //Customer.GetLemonadeRecipe (recipe) //CustomerActsOnRecipe
                //Recipe.SubtractRecipefromInventory(lemonadeStand) //RecipeActsOnLemonadeStand
                //Recipe.AddPlayerMoney (cashbox) //RecipeActsOnCashBox
                //LemonadeStand.SubtractInventoryLemonadeStand(Inventory) //LemonadeStandActsOnInventory 
                //Inventory.GetInventory(day)  //InventoryActsOnDay 
                //Day.GetDay(player) //DayActsOnPlayer
                //numberOfDays++;
            }


            //sell items to player
            store.SellLemons(player);
           /* store.AddLemonToInventory(player)*/;
            store.SellSugar(player);
            //store.AddSugarToInventory(player);
            store.SellIce(player);
            //store.AddIceToInventory(player);
        }

        //public int GetStatus() //Method for assigning "score/budget"
        //{
        //    numberCounter = 0;
        //    while (numberCounter < 100)
        //    {
        //        numberCounter++
        //                Console.WriteLine("Your present balance is {0}", numberCounter);
        //    }
        //}
}














    //public void Game() //constructor
    //{
    //    this.playerOne = new Player();
    //    this.playerTwo = new Player();
    //    this.numberOfDays = 7;
    //    this.day = 0;
    //}

    //public void RunGame()
    //{
    //    Console.WriteLine("Welcome to my LemonadeStand Game");
    //    while (this.day <this.numberOfDays) //Gaming Loop
    //    {

    //        Console.WriteLine("Welcome to day {0}", this.day);
    //        LemonadeStand lemonadeStand = new LemonadeStand();
    //        lemonadeStand.RunStand();
    //        this.day++;
    //    }
    //}

}
