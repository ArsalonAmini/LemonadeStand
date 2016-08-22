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
            //this.PredictWeather();
            //inventory.GetInventory();
            player.BuyLemons();
            player.BuySugar();
            player.BuyIce();
            weather.ActualWeather();
            player.SetSweetLemonadePrice();
            player.SetRegularLemonadePrice();
            player.SetTartLemonadePrice();
            recipe.MakeLemonade();
            tartRecipe.MakeLemonade();
            sweetRecipe.MakeLemonade();
            CalculateCustomerPreference(potentialCustomers);
            MakeCustomerBuyLemonade(potentialCustomers);

            //salesLoop //recipe.AddPlayerMoney(cashBox); //RecipeActsOnCashBox
            //Foreach potential customer do they buy or not buy
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

        public List<Customer> CalculateCustomerPreference(List<Customer> potentialCustomers) //verified by A.Amini-Hajibashi, built on 8/20/2016
        {
            foreach (Customer customer in potentialCustomers) //does this function gen a list of objects with customer preference attribute??
            {
                customer.customerPreference = random.Next(1, 4);
            }
            return potentialCustomers;
        }

        public void MakeCustomerBuyLemonade(List<Customer> potentialCustomers) //tested and verifed by A.Amini-Hajibashi  8/22/2016
        {
            foreach (Customer customer in potentialCustomers)
            {
                if (customer.customerPreference == 1)
                {
                    //recipe for sweet
                    Console.WriteLine("Customer bought sweet lemonade!");
                    //return potentialCustomers;
                }
                else if (customer.customerPreference == 2)
                {
                    //recipe tart
                    //tartRecipe.MakeLemonade();
                    Console.WriteLine("Customer bought a tart lemonade!");
                    //return potentialCustomers;
                }
                else if (customer.customerPreference == 3)
                {
                    Console.WriteLine("Customer did not buy lemonade!");
                }
                else
                {
                    //recipe for normal
                    //recipe.MakeLemonade();
                    Console.WriteLine("Customer didn't buy lemonade!");
                    //return potentialCustomers;
                }
            }
        }



        public double AddSaleToCashBox(List<Customer> potentialCustomers, CashBox cashBox) //Player player) //testing by A.Amini-Hajibashi 8/22/16
        {
            double totalToAddToCashbox = 0;

            foreach (Customer customer in potentialCustomers)
            {
                if (customer.customerSweet == 1)
                {
                    totalToAddToCashbox += cashBox.balance + 1.20; //player.lemonadePrice; 
                }
                else if (customer.customerTart == 1)
                {
                    totalToAddToCashbox += cashBox.balance + 1.05; //player.lemonadePrice;
                }
                else if (customer.customerRegular == 1)
                {
                    totalToAddToCashbox = cashBox.balance + 1.00; //player.lemonadePrice;
                }
                else
                {
                    totalToAddToCashbox = cashBox.balance;
                }

            }
            return totalToAddToCashbox;
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
    }






