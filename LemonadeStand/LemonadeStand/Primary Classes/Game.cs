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
        Inventory inventory = new Inventory();
        CashBox cashBox = new CashBox();
        Price price = new Price();
        Demand demand = new Demand();
        Tertiary_Classes.Recipe recipe = new Tertiary_Classes.Recipe();
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
                inventory.PrintInventoryStatus(player); //InventoryActsOnPlayer
                cashBox.PrintPlayerMoney(player); //CashBoxActsOnPlayer
                store.SellLemons(player); //StoreActsOnPlayer
                store.SellSugar(player); //StoreActsOnPlayer
                store.SellIce(player); //StoreActsOnPlayer
                player.BuyLemons(store); //PlayerActsOnStore
                player.BuySugar(store); //PlayerActsOnStore
                player.BuyIce(store); //PlayerActsOnStore
                inventory.PrintInventoryStatus(player); //InventoryActsOnPlayer(GetInventory)
                player.SetLemonadePrice(price);  //PlayerActsOnPrice 
                weather.GetDay(day); //WeatherActsOnDay
                day.CalculateDemand(demand); //DayActsOnDemand
                day.GetWeather(weather); //weatherActsOnDay
                //price.SetPrice(demand); //PriceActsOnDemand
                demand.CalculateBuyerChance(customer); //DemandActsOnCustomer
                //customer.GetLemonadeRecipe(recipe); //CustomerActsOnRecipe
                //recipe.SubtractRecipefromInventory(lemonadeStand); //RecipeActsOnLemonadeStand
                recipe.AddPlayerMoney(cashBox); //RecipeActsOnCashBox
                //LemonadeStand.SubtractInventoryLemonadeStand(Inventory); //LemonadeStandActsOnInventory 
                inventory.GetInventory(day);  //InventoryActsOnDay 
                day.GetDay(player); //DayActsOnPlayer
                numberOfDays++;
            }
        }

    }
}














    


