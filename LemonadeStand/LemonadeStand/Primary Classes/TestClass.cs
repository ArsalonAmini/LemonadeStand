using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Primary_Classes
{
    class TestClass
    {
        Customer customer;
        Random random;
        private int customerPreference;
        int customerSweet;
        int customerTart;
        int customerNormal;
        CashBox cashbox;

        public TestClass()
        {
            this.customer = new Customer();
            this.random = new Random();
            this.cashbox = new CashBox();
        }

        public List<Customer> GeneratePotentialCustomers(int numberOfPotentialCustomers) //Verified and Tested by A Amini-Hajibashi

        {
            List<Customer> potentialCustomers = new List<Customer>();
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
                    customer.customerSweet = 1;
                    Console.WriteLine("Customer bought sweet lemonade!");
                    //return potentialCustomers;
                }
                else if (customer.customerPreference == 2)
                {
                    //recipe tart
                    //tartRecipe.MakeLemonade();
                    customer.customerTart = 1;
                    Console.WriteLine("Customer bought a tart lemonade!");
                    //return potentialCustomers;
                }
                else if (customer.customerPreference == 3)
                {
                    customer.customerRegular = 1;
                    Console.WriteLine("Customer did not buy lemonade!");
                }
                else
                {
                    customer.customerRegular = 1;
                    //recipe.MakeLemonade();
                    Console.WriteLine("Customer didn't buy lemonade!");
                    //return potentialCustomers;
                }
            }
        }
    }
}

        //}


        //Player player = new Player();
        //private double tartLemonadePrice;
        //private double sweetLemonadePrice;
        //private double regularLemonadePrice;
        //private double totalToAddToCashBox;

        //public double SetTartLemonadePrice() //Tested and verified by A Amini-Hajibashi 8/19/2016 //modifeid and retested on 8/19/2016
        //{
        //    Console.WriteLine("How much would you like to sell your TartLemonade for today?");
        //    tartLemonadePrice = Convert.ToDouble(Console.ReadLine());
        //    return tartLemonadePrice;
        //}

        //public double SetSweetLemonadePrice() //Tested and verified by A Amini-Hajibashi 8/22/2016
        //{
        //    Console.WriteLine("How much would you like to sell your SweetLemonade for today?");
        //    sweetLemonadePrice = Convert.ToDouble(Console.ReadLine());
        //    return sweetLemonadePrice;
        //}

        //public double SetRegularLemonadePrice() //Tested and verified by A Amini-Hajibashi 8/22/2016
        //{
        //    Console.WriteLine("How much would you like to sell your RegularLemonade for today?");
        //    regularLemonadePrice = Convert.ToDouble(Console.ReadLine());
        //    return regularLemonadePrice;
        //}






       


        //public double AddSaleToCashBox(List<Customer> potentialCustomers) //testing by A.Amini-Hajibashi 8/22/16
        //{
        //    double totalToAddToCashBox = 0;

        //    foreach (Customer customer in potentialCustomers)
        //    {
        //        if (customer.customerSweet == 1)
        //        {
        //            totalToAddToCashBox += this.sweetLemonadePrice; //player.lemonadePrice; 
        //        }
        //        else if (customer.customerTart == 1)
        //        {
        //            totalToAddToCashBox += this.sweetLemonadePrice; //player.lemonadePrice;
        //        }
        //        else if (customer.customerRegular == 1)
        //        {
        //            totalToAddToCashBox += this.regularLemonadePrice; //player.lemonadePrice;
        //        }
        //        else
        //        {
        //            totalToAddToCashBox = 0;
        //        }

        //    }
        //    return totalToAddToCashBox;
        //}

    //    public double AddTotalToCashBox(double totalToAddToCashBox, CashBox cashBox)
    //    {
    //        cashBox.balance = cashBox.balance + totalToAddToCashBox;
    //        return cashBox.balance;
    //    }

    //}

//}
     
       





