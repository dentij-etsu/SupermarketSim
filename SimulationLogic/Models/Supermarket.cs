///////////////////////////////////////////////////////////////////////////////
//
// Author: Jackson Denti, dentij@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 4
// Description: Class to simulate customers arriving at a supermarket and getting checked out
//
///////////////////////////////////////////////////////////////////////////////
using System.Collections.Specialized;
using SimulationLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLogic
{
    public class Supermarket : ISupermarket
    {
        internal List<Register> registers = new List<Register>();
        internal int longestLine = 0;
        internal int customersArrived = 0;
        internal int customersServed = 0;
        internal double totalSales = 0;
        internal double averageCustomerTotal = 0;
        internal double minimumCustomerTotal = 0;
        internal double maximumCustomerTotal = 0;
        private int registersOpen;
        Random rng = new Random();

        // "Ticks" of the run method, used to simulate time spent putting items in cart
        int cycles = 0;

        // List for customers to wait in while time putting items in cart is simulated
        List<Customer> customers = new List<Customer>();

        // field for managing all the listboxes underneath the labels
        public List<string>[] registerStrings = new List<string>[15];

        /// <summary>
        /// Driver method for Supermarket simulation.
        /// Creates and adds registers, customers, and items supermarket
        /// Manages sales related statistics for gui elements
        /// Manages customersID for listbox gui elements
        /// </summary>
        public void Run()
        {
            //Your code to run the simulation goes here
            //...

            // Creates a random number of customers and starting open registers
            int totalCustomers = rng.Next(450) + 50;
            int registersOpen = rng.Next(10) + 5;

            // Initalizes registers for supermarket
            for (int i = 0; i < 15; i++)
            {
                Register reg = new Register(i);
                registers.Add(reg);
            }

            // Initializes string lists for gui Listbox management
            for (int i = 0; i < 15; i++)
            {
                List<string> strs = new List<string>();
                registerStrings[i] = strs;
            }
         
            // Iterates while all customers have yet to be served, managing customer interations
            while (customersServed != totalCustomers)
            {
                // If loop determines customer should arrive with a probability on a "Normal" curve
                if (customersArrived < totalCustomers && ShouldCustomerArrive(totalCustomers))
                {
                    // Creates a new customer with the appropriate ID
                    Customer customer = new Customer(customersArrived + 1);
                    customersArrived++;

                    // Loop to iteratively add Items to a customer object
                    for (int i = rng.Next(25) + 5; i >= 0; i--)
                    {
                        int itemIndex = rng.Next(0, 39);
                        Item item = new Item(FindItemName(itemIndex), FindItemPrice(itemIndex));
                        customer.AddToCart(item);
                    }

                    // Determines when a customer
                    customer.arrivalTick = cycles + (customer.cart.Count);
                    customers.Add(customer);
                }

                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].arrivalTick <= cycles)
                    {
                        // Temp registers object for use in opening and closing registers for foot traffic
                        // and adding each cutomer to the shortest avaiable line
                        Register shortestRegister = FindShortestLine(registersOpen);

                        if (shortestRegister.line.Count > 4 && registersOpen < 15) registersOpen++;
                        if (shortestRegister.line.Count < 2 && registersOpen > 5) registersOpen--;

                        // Adds customer ID the register strings for updating GUI listboxes
                        registerStrings[shortestRegister.id].Add($"{customers[i].id}");

                        shortestRegister.JoinLine(customers[i]);
                        customers.RemoveAt(i);
                    }
                }
                CheckOutCustomer();               
                Thread.Sleep(60);
                cycles++;
            }
        }

        /// <summary>
        /// Evalutes a point on a normal curve using a percentage of customers arrived as the x value.
        /// Takes random double and determines if that is higher or lower than the normal value evaluted and 
        /// returns true or false to simulate customers randomly arriving on a "normal" curve
        /// </summary>
        /// <param name="totalCustomers"> The total number of customers to be simulated </param>
        /// <returns> Returns a bool value to determine if a customer should "Arrive" or not </returns>
        public bool ShouldCustomerArrive(int totalCustomer)
        {
            double chance = rng.NextDouble() * 1.098;

            // Prog represents the progression of customers that have arrived, mapped to a range between 0.0 and 2.0
            double prog = (double)customersArrived / ((double)totalCustomer / 2);

            // Simplifed formula for Normal Curve, taking the customer progression for x input
            double normal = Math.Pow(3, -2 + 3.8 * prog - 2 * prog * prog);

            if (normal > chance) return true;
            return false;
        }

        /// <summary>
        /// Returns a value from an array given an index. Intended to be used in conjuction with FindItemPrice
        /// Index for both methods should be the same. Names are paired with the price at the same index in FindItemPrice
        /// </summary>
        /// <param name="index"> Value to pass as index to method array </param>
        /// <returns> Returns name out of an array at index </returns>
        public string FindItemName (int index)
        {
            // Creates an array of commonly bought super market items with some humorous exceptions
            string[] names = new string[]
            {
                "Gum", "Bread", "Eggs", "Paper Towels 12pk", "Detergent", "Honey", "Lightbulbs", "Bagged Milk", "Flour, 5lb", "Sugar, 5lb",
                "Medicine", "Beef", "Wine", "Movie", "Flowers", "Candy", "Soup", "Poultry", "Ketchup", "Peanut Butter",
                "Diapers", "Fortnite Giftcard", "Cleaners", "Oil", "Shampoo", "Muffins", "Salt", "Rice, 5lb", "Toilet Paper", "Ice Cream",
                "Soda", "Fruit", "Coffee Beans", "Chips", "Protein Powder", "Batteries", "TV", "Party Supplies", "$100 worth of nickels", "Birthday Cake"
            };
            return names[index];
        }

        /// <summary>
        /// Returns a value from an array given an index. Intended to be used in conjuction with FindItemName
        /// Index for both methods should be the same. Prices are paired with the name at the same index in FindItemName
        /// </summary>
        /// <param name="index"> Value to pass as index to method array </param>
        /// <returns> Returns value out of an array at index, represents a price in USD </returns>
        public double FindItemPrice (int index)
        {
            // Prices are treated as a paired value with a specific item from the FindItemName method
            // Each element references the average 2022 price, in USD, of the coordinating item from the FindItemName method
            // With some exceptions to fit the price range specs of this project.
            double[] price = new double[]
            {
                0.50, 1.75, 2.90, 13.99, 12.99, 5.00, 14.94, 3.99, 2.48, 2.95,
                10.00, 10.24, 9.98, 19.99, 21.99, 1.35, 4.65, 3.09, 3.08, 2.55,
                11.24, 19.00, 6.99, 2.64, 6.16, 4.95, 0.99, 6.75, 5.99, 5.52,
                1.25, 4.00, 5.91, 1.79, 23.34, 24.94, 99.99, 65.00, 100.00, 60.00
            };

            return price[index];
        }

        /// <summary>
        /// Iterates through all the register opened to find the register with the shortest line
        /// </summary>
        /// <param name="registersOpen"> Number of registers that a customer can join at method call time </param>
        /// <returns> Returns the register object with the fewest customers queued </returns>
        public Register FindShortestLine (int registersOpen)
        {
            Register reg = registers[0];

            for (int i = 0; i < registersOpen; i++)
            {
                if (registers[i].line.Count < reg.line.Count)                
                    reg = registers[i];               
            }
            return reg;
        }

        /// <summary>
        /// Iterates through all the registers opened to find the longest line
        /// </summary>
        /// <returns> Returns the number of customers that are in the longest line </returns>
        public int FindLongestLine()
        {
            Register reg = registers[0];

            for (int i = 1; i < this.registersOpen; i++)
            {
                if (registers[i].line.Count > reg.line.Count) 
                    reg = registers[i];
            }
            return reg.line.Count;
        }

        /// <summary>
        /// Iterates through every register with a customer and "scans" and item and removes it from the customers cart
        /// If the customer does not have any items, they are removed from the queue
        /// If a customer is removed from a queue, the method updates the relevant stats and GUI elements
        /// </summary>
        private void CheckOutCustomer()
        {
            // 15 is used to indicate the number of registers that gets checked
            for (int i = 0; i < 15; i++)
            {
                // Iterates through every register that has a customer and manages checkout process
                if (registers[i].line.Count > 0)
                {
                    Customer customer = registers[i].line.Peek();

                    // Checks if each customer has items in their cart and removes one per customer
                    if (customer.cart.Count > 0)
                    {
                        registers[i].AddSales(customer.RemoveFromCart().price);
                    }
                    else
                    {
                        registers[i].CheckOut();
                        Thread.Sleep(1);

                        // Updates statistics associated with a customer being removed from line
                        longestLine = FindLongestLine();
                        totalSales += customer.totalCartValue;
                        customersServed++;
                        averageCustomerTotal = totalSales / customersServed;

                        // Conditionals to determine if the min or max cart value needs to be updated
                        if (customer.totalCartValue < minimumCustomerTotal || minimumCustomerTotal == 0)
                            minimumCustomerTotal = customer.totalCartValue;
                        if (customer.totalCartValue > maximumCustomerTotal)
                            maximumCustomerTotal = customer.totalCartValue;                      

                        // Removes customer id from appropriate listbox
                        registerStrings[i].Remove($"{customer.id}");                    
                    }
                }
            }
        }
    }
}
