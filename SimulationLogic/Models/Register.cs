///////////////////////////////////////////////////////////////////////////////
//
// Author: Jackson Denti, dentij@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 4
// Description: Class for simulating a register as a part of a supermarket
//
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLogic
{
    public class Register
    {
        internal int id;
        internal Queue<Customer> line = new Queue<Customer>();
        internal double totalSales;
        int customersServed;

        /// <summary>
        /// Constructor for register object
        /// </summary>
        /// <param name="id"> the id value of register </param>
        public Register(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Adds a customer object to the register queue
        /// </summary>
        /// <param name="customer"> new customer to be added in line </param>
        public void JoinLine(Customer customer)
        {
            line.Enqueue(customer);
        }

        /// <summary>
        /// Removes the customer at the front of the line and increments customersServed
        /// </summary>
        /// <returns> Dequeued customer </returns>
        public Customer CheckOut()
        {
            customersServed++;
            return line.Dequeue();
        }

        /// <summary>
        /// Adds sales to total sales for register
        /// </summary>
        /// <param name="sales"> amount of sales to be added, in USD decimal form </param>
        public void AddSales(double sales)
        {
            totalSales += sales;
        }
    }
}
