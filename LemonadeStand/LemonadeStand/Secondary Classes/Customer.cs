using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        Random random;
        public int customerPreference;
        public List<Customer> potentialCustomers;
        public int customerSweet;
        public int customerTart;
        public int customerRegular;

        public Customer() //constructor
        {
            this.random = new Random();
        }

       
        public void AddSaleToCashBox(List<Customer> potentialCustomers) //tested and verified by A.Amini-Hajibashi 8/22/16
        {
            foreach (Customer customer in potentialCustomers)
            {
                if (customer.customerSweet == 1)
                {
                    //balance = balance + 1.20
                    //return balance;
                    Console.WriteLine("it works");
                }
                else if (customer.customerTart == 1)
                {
                    //balance = balance + 1.05
                    //return balance;
                    Console.WriteLine("it works");
                }
                else if (customer.customerRegular == 1)
                {
                    //balance = balance + 1.00
                    //return balance;
                    Console.WriteLine("it works");
                }
                else
                {
                    //balance = balance 
                    //return balance;
                    Console.WriteLine("it works");
                }

            }

        }

    }
    }





