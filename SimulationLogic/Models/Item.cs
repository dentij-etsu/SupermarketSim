///////////////////////////////////////////////////////////////////////////////
//
// Author: Jackson Denti, dentij@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 4
// Description: Class for simulating an item inside a customer cart at a supermarket
//
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLogic
{
    public class Item
    {
        string name;
        internal double price;

        /// <summary>
        /// Constructor for Item object 
        /// </summary>
        /// <param name="name"> variable depicting object name </param>
        /// <param name="price"> item price, in USD double form </param>
        public Item(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
