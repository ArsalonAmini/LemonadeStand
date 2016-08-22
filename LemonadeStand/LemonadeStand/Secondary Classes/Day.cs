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
        Player player;
        Random random;
        Tertiary_Classes.Recipe recipe;
        Tertiary_Classes.TartRecipe tartRecipe;
        Tertiary_Classes.SweetRecipe sweetRecipe;


        int numberOfPotentialCustomers = 100;

        public Day()
        {
            this.weather = new Weather();
            this.customer = new Customer();
            this.demand = new Demand();
            this.cashBox = new CashBox();
            this.inventory = new Inventory();
            this.player = new Player();
            this.random = new Random();
            this.recipe = new Tertiary_Classes.Recipe();
            this.tartRecipe = new Tertiary_Classes.TartRecipe();
            this.sweetRecipe = new Tertiary_Classes.SweetRecipe();
        }

        public void RunDay()
        {

            GeneratePotentialCustomers(numberOfPotentialCustomers);
            cashBox.PrintBalance();
            weather.PredictWeather();
            //inventory.GetInventory();
            player.BuyLemons();
            player.BuySugar();
            player.BuyIce();
            weather.ActualWeather();
            player.SetSweetLemonadePrice();
            player.SetRegularLemonadePrice();
            player.SetTartLemonadePrice();
            //recipe.MakeLemonade();
            //tartRecipe.MakeLemonade();
            //sweetRecipe.MakeLemonade();
            customer.CalculateCustomerPreference(potentialCustomers);
            customer.MakeCustomerBuyLemonade(potentialCustomers);
            cashBox.AddSaleToCashBox(potentialCustomers);
            double totalToAddToCashBox = cashBox.AddSaleToCashBox(potentialCustomers);
            cashBox.AddTotalToCashBox(totalToAddToCashBox, cashBox);

            //recipe.SubtractRecipefromInventory(lemonadeStand); //RecipeActsOnLemonadeStand
            //endOfDay Status(money, customers, inventory)
            //cashBox.PrintPlayerMoney(player); //CashBoxActsOnPlayer
            //inventory.PrintInventoryStatus(player); //InventoryActsOnPlayer
        }

        public List<Customer> GeneratePotentialCustomers(int numberOfPotentialCustomers) //Verified and Tested by A Amini-Hajibashi

        {

            for (int i = 0; i < numberOfPotentialCustomers; i++)
            {
                Customer customer = new Customer();
                potentialCustomers.Add(new Customer());
            }
            return potentialCustomers;

        }


    }
}






