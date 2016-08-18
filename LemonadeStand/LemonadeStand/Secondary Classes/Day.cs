using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {

        Weather weather;
        Customer customer;
        Demand demand;
        public List<Customer> potentialCustomers = new List<Customer>();
        CashBox cashBox;
        Inventory inventory;

        public Day()
        {
            this.weather = new Weather();
            this.customer = new Customer();
            this.demand = new Demand();
            this.cashBox = new CashBox();
            this.inventory = new Inventory();
        }

        public void RunDay()
        {

            GeneratePotentialCustomers();
            cashBox.PrintBalance();
            weather.PredictWeather();
            inventory.GetInventory();
            //player.BuyLemons(store); //PlayerActsOnStore
                                     
            //player.BuySugar(store); //PlayerActsOnStore                          
            //player.BuyIce(store); //PlayerActsOnStore                          
            //store.SellLemons(player); //StoreActsOnPlayer                         
            //store.SellSugar(player); //StoreActsOnPlayer
            //store.SellIce(player); //StoreActsOnPlayer


            //Make lemonade (customer chose recipe, rand (1,2) customer chose tart or sweet)
            //salesLoop
            //Foreach potential customer do they buy or not buy
            //endOfDay Status(money, customers, inventory)
            //getPotentialCustomers();
            //cashBox.PrintPlayerMoney(player); //CashBoxActsOnPlayer
            //inventory.PrintInventoryStatus(player); //InventoryActsOnPlayer


            //inventory.PrintInventoryStatus(player); //InventoryActsOnPlayer(GetInventory)
            //player.SetLemonadePrice(price);  //PlayerActsOnPrice 
            //weather.GetDay(day); //WeatherActsOnDay
            //day.CalculateDemand(demand); //DayActsOnDemand
            //day.GetWeather(weather); //weatherActsOnDay
            //price.SetPrice(demand); //PriceActsOnDemand
            //demand.CalculateBuyerChance(customer); //DemandActsOnCustomer
            //customer.GetLemonadeRecipe(recipe); //CustomerActsOnRecipe
            //recipe.SubtractRecipefromInventory(lemonadeStand); //RecipeActsOnLemonadeStand
            //recipe.AddPlayerMoney(cashBox); //RecipeActsOnCashBox
            //LemonadeStand.SubtractInventoryLemonadeStand(Inventory); //LemonadeStandActsOnInventory 
            //inventory.GetInventory(day);  //InventoryActsOnDay 
            //day.GetDay(player); //DayActsOnPlayer
            //numberOfDays++;
        }
        public void GeneratePotentialCustomers()
        {
            int numberOfPotentialCustomers = 100;

            for (int i = 0; i < numberOfPotentialCustomers; i++)
            {
                Customer customer = new Customer();
                potentialCustomers.Add(new Customer());

            }
        }
    }

}




