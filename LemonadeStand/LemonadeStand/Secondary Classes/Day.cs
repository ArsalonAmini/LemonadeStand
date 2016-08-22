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
        private int customerPreference;
       
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

            customer.GeneratePotentialCustomers(numberOfPotentialCustomers);
            cashBox.PrintBalance();
            //this.PredictWeather();
            //inventory.GetInventory();
            player.BuyLemons();
            player.BuySugar();                           
            player.BuyIce();
            weather.ActualWeather();
            recipe.MakeLemonade();
            tartRecipe.MakeLemonade();
            sweetRecipe.MakeLemonade();
            customer.CalculateCustomerPreference(potentialCustomers);
            customer.MakeCustomerBuyLemonade(potentialCustomers);

            //salesLoop //recipe.AddPlayerMoney(cashBox); //RecipeActsOnCashBox
            //Foreach potential customer do they buy or not buy
            //recipe.SubtractRecipefromInventory(lemonadeStand); //RecipeActsOnLemonadeStand
            //endOfDay Status(money, customers, inventory)
            //cashBox.PrintPlayerMoney(player); //CashBoxActsOnPlayer
            //inventory.PrintInventoryStatus(player); //InventoryActsOnPlayer

        }

       
        }
        //public void PredictWeather() //tested and verified by A Amini-Hajibashi on 8/17/2016
        //{
        //    Random random = new Random();
        //    int predictedWeather = random.Next(1, 100);

        //    if (predictedWeather > 50)
        //    {
        //        Console.WriteLine("The predicted forcast for the next 7 days is sunny");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The predicted forcast for the next 7 days is raining!");
        //    }
        //}

        //public int ActualWeather() //Tested and verified by A Amini-Hajibashi on 8/19/2016
        //{
        //    int actualWeather = random.Next(1, 100);

        //    if (actualWeather > 50)
        //    {
        //        weather = 1;
        //        Console.WriteLine("It's sunny");
        //        return weather;
        //    }
        //    else if (actualWeather < 50)
        //    {
        //        weather = 0;
        //        Console.WriteLine("It's raining");
        //        return weather;
        //    }
        //    else
        //    {
        //        Console.WriteLine("The weather is partly sunny today");
        //        weather = 2;
        //        return weather;
        //    }
        //}

    

}




