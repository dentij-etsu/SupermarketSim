///////////////////////////////////////////////////////////////////////////////
//
// Author: Jackson Denti, dentij@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 4
// Description: Class for managing GUI elements in a Windows Form
//
///////////////////////////////////////////////////////////////////////////////
using System;
using SimulationLogic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLogic
{
    public class GuiController : IGuiController
    {
        /// <summary>
        /// Implements <see cref="IGuiController.UpdateUI(Supermarket, string[], List{string}[], ISupermarketStatistics)"/>
        /// </summary>
        public void UpdateUI(Supermarket supermarket, string[] queueLabels, List<string>[] queueOfCustomers, ISupermarketStatistics supermarketStatistics)
        {
            // This loop manages the register labels as well as the queue listboxes
            for (int i = 0; i < 15; i++)
            {
                queueOfCustomers[i] = supermarket.registerStrings[i];

                // Updates labels above list format by concatinating register id
                // with the number of items remaining with the customer at front of line
                if (supermarket.registers[i].line.Count > 0)
                {
                    string itemCount = "" + supermarket.registers[i].line.Peek().cart.Count;
                    string registerLabel = $"{i + 1}";
                    queueLabels[i] = $"{registerLabel.PadLeft(2, '0')}: {itemCount.PadLeft(2, '0')}";
                }
            }

            // Updates supermarketStatistics object with coordinating values from the passed supermarket
            supermarketStatistics.LongestLine = supermarket.longestLine;
            supermarketStatistics.CustomersArrived = supermarket.customersArrived;
            supermarketStatistics.CustomersDeparted = supermarket.customersServed;
            supermarketStatistics.AverageCustomerTotal = (decimal)supermarket.averageCustomerTotal;
            supermarketStatistics.MinimumCustomerTotal = (decimal)supermarket.minimumCustomerTotal;
            supermarketStatistics.MaximumCustomerTotal = (decimal)supermarket.maximumCustomerTotal;
            supermarketStatistics.TotalSales = (decimal)supermarket.totalSales;

        }
    }
}