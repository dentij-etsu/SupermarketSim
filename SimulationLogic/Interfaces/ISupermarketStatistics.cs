using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLogic
{
    /// <summary>
    /// Data store for updating labels in the program's GUI.
    /// Values are used to update the appropriate label in the
    /// window's form.
    /// </summary>
    public interface ISupermarketStatistics
    {
        /// <summary>
        /// The longest line in the super market thus far
        /// </summary>
        public int LongestLine { get; set; }
        /// <summary>
        /// Total number of customers who have entered the supermarket
        /// </summary>
        public int CustomersArrived { get; set; }
        /// <summary>
        /// Total number of customers who have exited the supermarket
        /// </summary>
        public int CustomersDeparted { get; set; }
        /// <summary>
        /// Average amount a customer spends in USD at the supermarket
        /// </summary>
        public decimal AverageCustomerTotal { get; set; }
        /// <summary>
        /// The lowest amount any customer has paid in USD at the supermarket
        /// </summary>
        public decimal MinimumCustomerTotal { get; set; }
        /// <summary>
        /// The highest amount any customer has paid in USD at the supermarket
        /// </summary>
        public decimal MaximumCustomerTotal { get; set; }
        /// <summary>
        /// The total amount all customer's have spent at the supermarket across the entire simulation
        /// </summary>
        public decimal TotalSales { get; set; }
    }
}
