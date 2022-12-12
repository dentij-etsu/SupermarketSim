using System.ComponentModel;
using SimulationLogic;
using SimulationLogic.Models;
using System.Linq;

namespace SupermarketSim {
	public partial class Simulation : Form {
		public Simulation() {
			InitializeComponent();
		}

		private void RunBtn_Click(object sender, EventArgs e) {
			//The line below initializes your Supermarket class. 
			Supermarket supermarket = new Supermarket();
			IGuiController controller = new GuiController();
			ISupermarketStatistics supermarketStatistics = new SuperMarketStatistics();

			//Use a backgroundworker to RunNewSim with the initialized supermarket
			BackgroundWorker bw = new BackgroundWorker();
			bw.WorkerSupportsCancellation = true;
			bw.DoWork += (o, ea) => {
				RunNewSim(supermarket);
				bw.CancelAsync();
			};

			bw.RunWorkerAsync();

			//While the backgroundworker is running, update the display
			while (bw.CancellationPending == false) {
				//Your code to update the display goes here
				simulationLoop(supermarket, controller, supermarketStatistics);
                //redraw
                this.Refresh();
            }
		}

		/// <summary>
		/// Update form elements each iteration of the loop in
		/// <see cref="RunBtn_Click(object, EventArgs)"/>.
		/// </summary>
		/// <param name="supermarket"></param>
		/// <param name="controller"></param>
		/// <param name="supermarketStatistics"></param>
		public void simulationLoop(Supermarket supermarket, IGuiController controller, ISupermarketStatistics supermarketStatistics)
		{
            // Repare labels and registers
            Label[] labelForms = new Label[] {
                    R1Queue ,
                    R2Queue ,
                    R3Queue ,
                    R4Queue ,
                    R5Queue ,
                    R6Queue ,
                    R7Queue ,
                    R8Queue ,
                    R9Queue ,
                    R10Queue,
                    R11Queue,
                    R12Queue,
                    R13Queue,
                    R14Queue,
                    R15Queue
                };
            string[] labelTexts = labelForms.Select(x => x.Text).ToArray();
            List<string>[] registers = SetupRegisters();

            // Execute student's code to update the UI
            controller.UpdateUI(supermarket, labelTexts, registers, supermarketStatistics);

            // take the results and update the UI
            UpdateLabels(labelForms, labelTexts);
			UpdateRegisters(registers);
			UpdateStats(supermarketStatistics);
        }

        /// <summary>
        /// Use data from a <see cref="ISuperMarketStatistics"/> typed object
		/// to update labels on the form. Data from the stat's parameter is
		/// formatted here.
        /// </summary>
        /// <param name="stats">Reference to supermarket statistics 
		/// representing the current state of the simulation</param>
        private void UpdateStats(ISupermarketStatistics stats) 
		{
			LQueue.Text = stats.LongestLine.ToString();
			CArrived.Text = stats.CustomersArrived.ToString();
			CDeparted.Text = stats.CustomersDeparted.ToString();
			AvgTotal.Text = "$" + stats.AverageCustomerTotal.ToString("0.00");
			MinTotal.Text = "$" + stats.MinimumCustomerTotal.ToString("0.00");
			MaxTotal.Text = "$" + stats.MaximumCustomerTotal.ToString("0.00");
			TotalSales.Text = "$" + stats.TotalSales.ToString("0.00");
        }

        /// <summary>
        /// Updates the ListBox's in the form. Each item in the array
        /// maps to a different ListBox in the form representing a 
        /// register in the supermarket. Each item in the list maps
        /// to a string inside of the ListBox's items.
        /// </summary>
		/// <exception cref="Exception">The length of 
		/// listBoxRegisterQueues and registers should always be equal
		/// and constant throughout the simulation.</exception>
        /// <param name="registers">An array of Lists that represent 
		/// values in the line for each register shown in the form</param>
        private void UpdateRegisters(List<string>[] registers) 
		{
			ListBox[] listBoxRegisterQueues = new ListBox[] { 
				Register1 ,
				Register2 ,
				Register3 ,
				Register4 ,
				Register5 ,
				Register6 ,
				Register7 ,
				Register8 ,
				Register9 ,
				Register10,
				Register11,
				Register12,
				Register13,
				Register14,
				Register15
			};

			if (listBoxRegisterQueues.Length != registers.Length)
			{
				throw new Exception("listBoxRegisterQueues and registers out of sync. Must be same length.");
			}

			for (int i = 0; i < listBoxRegisterQueues.Length; i++)
			{
                listBoxRegisterQueues[i].Items.Clear();
                listBoxRegisterQueues[i].Items.AddRange(registers[i].ToArray());


            }
		}

        /// <summary>
        /// Update's the text property of each label in the form
        /// that appears above a register representation.
        /// </summary>
        /// <exception cref="Exception">The length of labelForms and 
		/// labelTexts should always be equal and constant throughout 
		/// the simulation.</exception>
        /// <param name="labelForms">Array of all labels appearing 
		/// above registers in the form.</param>
        /// <param name="labelTexts">Strings to be placed into the 
		/// text field of each label.</param>
        private void UpdateLabels(Label[] labelForms, string[] labelTexts) 
		{
            if (labelForms.Length != labelTexts.Length)
            {
                throw new Exception("labelForms and labelTexts out of sync. Must be same length.");
            }

            for (int i = 0; i < labelForms.Length; i++)
			{
				labelForms[i].Text = labelTexts[i];
			}
		}

		/// <summary>
		/// Creates an array of list used to send data outside of a winform 
		/// environment. Each element of the array represents a collection
		/// of items in a ListBox. Each element of the list represents a 
		/// string of text inside the collection. This method pulls the 
		/// information out of the form, and packages it into the 
		/// correct format.
		/// </summary>
		/// <returns>An array of list of type string representing elements 
		/// in the listboxs on the form representing lines at a register.</returns>
		private List<string>[] SetupRegisters() 
		{
            List<string>[] queues = new List<string>[15];
            queues = queues.Select(x => x = new List<string>()).ToArray();

            foreach (var item in Register1 .Items){queues[ 0].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register2 .Items){queues[ 1].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register3 .Items){queues[ 2].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register4 .Items){queues[ 3].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register5 .Items){queues[ 4].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register6 .Items){queues[ 5].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register7 .Items){queues[ 6].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register8 .Items){queues[ 7].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register9 .Items){queues[ 8].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register10.Items){queues[ 9].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register11.Items){queues[10].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register12.Items){queues[11].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register13.Items){queues[12].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register14.Items){queues[13].Add(item?.ToString() ?? string.Empty);}
            foreach (var item in Register15.Items){queues[14].Add(item?.ToString() ?? string.Empty);}

			return queues;
        }

		/// <summary>
		/// Wrapper for the <see cref="Supermarket.Run()"/> method.
		/// </summary>
		/// <param name="sm">The supermarket simulation that you'd like to run</param>
        private void RunNewSim(Supermarket sm) => sm.Run();

		/// <summary>
		/// Exit the application when the "exit button", 
		/// i.e. the red 'X' in the top right of the 
		/// form, is pressed.
		/// </summary>
		/// <param name="sender">Ignored.</param>
		/// <param name="e">Ignored.</param>
		private void ExitBtn_Click(object sender, EventArgs e) => Application.Exit();
	}
}