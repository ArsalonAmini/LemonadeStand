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
                //Weather.GetDay(day) //WeatherActsOnDay
                //Day.GetWeather(demand) //DayActsOnDemand
                //Day.GetWeather(weather) //weatherActsOnDay
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
        }

    }
}














    


