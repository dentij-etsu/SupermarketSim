using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLogic
{
    /// <summary>
    /// Defines operations for interacting with the window's form
    /// application. Holds the logic for manipulating the form to
    /// maintain single responsibility principal, and promote code
    /// reusabilitiy.
    /// </summary>
    public interface IGuiController
    {
        /// <summary>
        /// Used by the run() method to control GUI elements in the windows
        /// form application. Logic is moved to an external module to
        /// maintain single responsibility and to not pollute the Form's class.
        /// </summary>
        /// <param name="supermarket">The supermarket currently being simulated</param>
        /// <param name="queueLabels">Array of all string elements in the form relating to labels above the Queues from left to right</param>
        /// <param name="queueOfCustomers">Array of List. 
        /// Each element of the array represents a listbox element on the form. 
        /// Each element of the list represents a string element inside of the listbox</param>
        /// <param name="supermarketStatistics">Data store for supermarket statistics used to update the appropriate labels in the windows form</param>
        public void UpdateUI(Supermarket supermarket, string[] queueLabels, List<string>[] queueOfCustomers, ISupermarketStatistics supermarketStatistics);
    }
}
