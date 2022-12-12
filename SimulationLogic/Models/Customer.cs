///////////////////////////////////////////////////////////////////////////////
//
// Author: Jackson Denti, dentij@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 4
// Description: Class for simulating a customer at a register
//
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLogic
{
    public class Customer
    {
        internal int id;
        internal Stack<Item> cart;

        internal int arrivalTick;

        // This field keeps of the totalCart value when filled
        // not decremented as items are removed for statistical purposes
        internal double totalCartValue = 0;

        /// <summary>
        /// Constructor for customer object
        /// </summary>
        /// <param name="id"> id number assigned sequentially </param>
        public Customer(int id)
        {
            this.id = id;
            cart = new Stack<Item>();
        }

        /// <summary>
        /// Adds an item to the stack represeting the "cart" and adds price to total cart value
        /// </summary>
        /// <param name="item"> new Item object to be pushed into "cart" stack </param>
        public void AddToCart(Item item)
        {
            totalCartValue += item.price;
            cart.Push(item);
        }

        /// <summary>
        /// Method for popping items out of the Stack representing Item objects in "cart"
        /// </summary>
        /// <returns> The item at the top of the stack </returns>
        public Item RemoveFromCart()
        {
            return cart.Pop();
        }
    }
}
