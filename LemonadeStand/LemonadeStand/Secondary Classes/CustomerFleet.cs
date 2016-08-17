using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Secondary_Classes
{
    public class CustomerFleet
    {
        private List<Customer> customer;
        private int numberOfRobots;

        public List<Customer> CreateCustomers(int numberOfCustomers)
        {
            Random rand = new Random();
            List<Customer> robots = new List<Customer>();
            for (int i = 0; i < numberOfRobots; i++)
            {
                //Customer customer = new Customer("Customer" + i, rand.Next(0, 4));
                //customer.Add(Customer);
            }
            return customer;
        }

        //{
        //public List<Customer> AdultCustomer = new List<Customer>();
        //public List<Robot> ChildCustomer = new List<Customer>();


        //public List<Customer> AddCustomerToFleet(List<Customer> Fleet, Customer Customer)
        //{
        //    Fleet.Add(Customer);
        //    return Fleet;
        //}

        //public void DisplayCustomersInFleet(List<Customer> Fleet)
        //{
        //    foreach (Customer customer in Fleet)
        //    {
        //        Console.WriteLine();
        //    }
        //}




    }
}
