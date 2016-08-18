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
        int numOfDays;
        private object customerList;

        public Day()
        {
            this.weather = new Weather();
            this.customer = new Customer();
            this.demand = new Demand();
        }

        public void RunDay()
        {
            
            while (numOfDays < 7) //day loop
            {
                //generatepotentialcustoers
                //display status (money, weather, inventory)
                //Buy inventory
                //Make lemonade (customer chose recipe, rand (1,2) customer chose tart or sweet)
                //salesLoop
                //Foreach potential customer do they buy or not buy
                //endOfDay Status(money, customers, inventory)
                //getPotentialCustomers();
                //cashBox.PrintPlayerMoney(player); //CashBoxActsOnPlayer
                //inventory.PrintInventoryStatus(player); //InventoryActsOnPlayer
                //store.SellLemons(player); //StoreActsOnPlayer
                //store.SellSugar(player); //StoreActsOnPlayer
                //store.SellIce(player); //StoreActsOnPlayer
                //player.BuyLemons(store); //PlayerActsOnStore
                //player.BuySugar(store); //PlayerActsOnStore
                //player.BuyIce(store); //PlayerActsOnStore
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

            public void GetPotentialCustomers()
            {
                int numberOfPotentialCustomers = 100;

                for (int i = 0; i < numberOfPotentialCustomers)
                {
                    customerList.Add(new Customer());
                    i++;
                }
            }
            public void Displaycustomers(List<Customer> customerList)
            {
                foreach (Customer customer in customerList)
                {
                    Console.WriteLine(customer.ChooseLemonadeType + "Buy/No Buy " + customer.BuyLemonade);
                }
            }

    }

}


        

    