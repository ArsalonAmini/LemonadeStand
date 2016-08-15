using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Customers
{
    class CustomerFleet
    {
        public List<Customer> AdultCustomers = new List<Customer>(); //creating a new list of objects "AdultCustomers" from Customer class
        public List<Customer> ChildCustomers = new List<Customer>();

        public List<Customer> AddCustomerToFleet (List<Customer> Fleet, Customer Customer) //constructor
        {
            Fleet.Add(Customer);
            return Fleet;
        }
        public void DisplayCustomersInFleet(List<Customer> Fleet)
        {
            foreach(Customer customer in Fleet)
            {
                Console.WriteLine(customer.name);
            }
        }
        public List<Customer> CreateCustomer(int numberOfCustomers)
        {
            Random rand = new Random();
            List<Customer> customers = new List<Customer>();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer customer = new Customer("Customer" + i, rand.Next(0, 4));
                customers.Add(customer);
            }
            return customers;
        }
    }
}
