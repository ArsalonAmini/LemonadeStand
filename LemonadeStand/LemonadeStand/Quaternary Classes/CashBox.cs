using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class CashBox 
    {
        //private double moneyFromCustomer;
        public double balance;
        CashBox cashBox;
        public double sweetLemonadePrice;
        public double tartLemonadePrice;
        public double regularLemonadePrice;

        public CashBox()
            {
            balance = 100;
            this.cashBox = new CashBox();
            }
        public void PrintBalance() //tested and verified 8/18/2016
        {
            Console.WriteLine("Your Cashbox contains the following");
            Console.WriteLine("You have ${0} in your cashbox", balance);
        }

        
        public double Debit(double cashSpent) //tested and verified 8/18/2016
        {
            balance = balance - cashSpent;
            return balance;
        }


        public double SetTartLemonadePrice() //Tested and verified by A Amini-Hajibashi 8/19/2016 //modified and retested on 8/19/2016 & 8/22/2016
        {
            Console.WriteLine("How much would you like to sell your TartLemonade for today?");
            tartLemonadePrice = Convert.ToDouble(Console.ReadLine());
            return tartLemonadePrice;
        }

        public double SetSweetLemonadePrice() //Tested and verified by A Amini-Hajibashi 8/22/2016
        {
            Console.WriteLine("How much would you like to sell your SweetLemonade for today?");
            sweetLemonadePrice = Convert.ToDouble(Console.ReadLine());
            return sweetLemonadePrice;
        }

        public double SetRegularLemonadePrice() //Tested and verified by A Amini-Hajibashi 8/22/2016
        {
            Console.WriteLine("How much would you like to sell your RegularLemonade for today?");
            regularLemonadePrice = Convert.ToDouble(Console.ReadLine());
            return regularLemonadePrice;
        }


        public double AddSaleToCashBox(List<Customer> potentialCustomers) //tested and verified by A.Amini-Hajibashi 8/22/16
        {
            double totalToAddToCashBox = 0;

            foreach (Customer customer in potentialCustomers)
            {
                if (customer.customerSweet == 1)
                {
                    totalToAddToCashBox += this.sweetLemonadePrice; 
                }
                else if (customer.customerTart == 1)
                {
                    totalToAddToCashBox += this.sweetLemonadePrice; 
                }
                else if (customer.customerRegular == 1)
                {
                    totalToAddToCashBox += this.regularLemonadePrice; 
                }
                else
                {
                    totalToAddToCashBox = 0;
                }

            }
            return totalToAddToCashBox;
        }

        public double AddTotalToCashBox(double totalToAddToCashBox, CashBox cashBox) //Tested and verified by A.Amini-Hajibashi on 8/22/2016
        {
            cashBox.balance = cashBox.balance + totalToAddToCashBox;
            return cashBox.balance;
        }


    }
}

