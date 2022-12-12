namespace SupermarketSim {
	partial class Simulation {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.RunBtn = new System.Windows.Forms.Button();
			this.RegPanelLabel = new System.Windows.Forms.Label();
			this.RegPanel = new System.Windows.Forms.Panel();
			this.R15Queue = new System.Windows.Forms.Label();
			this.R14Queue = new System.Windows.Forms.Label();
			this.R13Queue = new System.Windows.Forms.Label();
			this.R12Queue = new System.Windows.Forms.Label();
			this.R11Queue = new System.Windows.Forms.Label();
			this.R10Queue = new System.Windows.Forms.Label();
			this.R9Queue = new System.Windows.Forms.Label();
			this.R8Queue = new System.Windows.Forms.Label();
			this.R7Queue = new System.Windows.Forms.Label();
			this.R6Queue = new System.Windows.Forms.Label();
			this.R5Queue = new System.Windows.Forms.Label();
			this.R4Queue = new System.Windows.Forms.Label();
			this.R3Queue = new System.Windows.Forms.Label();
			this.R2Queue = new System.Windows.Forms.Label();
			this.Register15 = new System.Windows.Forms.ListBox();
			this.Register14 = new System.Windows.Forms.ListBox();
			this.Register13 = new System.Windows.Forms.ListBox();
			this.Register12 = new System.Windows.Forms.ListBox();
			this.Register11 = new System.Windows.Forms.ListBox();
			this.Register10 = new System.Windows.Forms.ListBox();
			this.Register9 = new System.Windows.Forms.ListBox();
			this.Register8 = new System.Windows.Forms.ListBox();
			this.Register7 = new System.Windows.Forms.ListBox();
			this.Register6 = new System.Windows.Forms.ListBox();
			this.Register5 = new System.Windows.Forms.ListBox();
			this.Register4 = new System.Windows.Forms.ListBox();
			this.Register3 = new System.Windows.Forms.ListBox();
			this.Register2 = new System.Windows.Forms.ListBox();
			this.Register1 = new System.Windows.Forms.ListBox();
			this.R1Queue = new System.Windows.Forms.Label();
			this.LQLabel = new System.Windows.Forms.Label();
			this.LQueue = new System.Windows.Forms.Label();
			this.CALabel = new System.Windows.Forms.Label();
			this.CArrived = new System.Windows.Forms.Label();
			this.CDLabel = new System.Windows.Forms.Label();
			this.CDeparted = new System.Windows.Forms.Label();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.AvgLabel = new System.Windows.Forms.Label();
			this.AvgTotal = new System.Windows.Forms.Label();
			this.MinLabel = new System.Windows.Forms.Label();
			this.MinTotal = new System.Windows.Forms.Label();
			this.MaxLabel = new System.Windows.Forms.Label();
			this.MaxTotal = new System.Windows.Forms.Label();
			this.TotalSales = new System.Windows.Forms.Label();
			this.TotalSalesLabel = new System.Windows.Forms.Label();
			this.RegPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// RunBtn
			// 
			this.RunBtn.Location = new System.Drawing.Point(847, 48);
			this.RunBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.RunBtn.Name = "RunBtn";
			this.RunBtn.Size = new System.Drawing.Size(59, 55);
			this.RunBtn.TabIndex = 9;
			this.RunBtn.Text = "Run";
			this.RunBtn.UseVisualStyleBackColor = true;
			this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
			// 
			// RegPanelLabel
			// 
			this.RegPanelLabel.AutoSize = true;
			this.RegPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.RegPanelLabel.Location = new System.Drawing.Point(15, 106);
			this.RegPanelLabel.Name = "RegPanelLabel";
			this.RegPanelLabel.Size = new System.Drawing.Size(99, 25);
			this.RegPanelLabel.TabIndex = 10;
			this.RegPanelLabel.Text = "Registers:";
			// 
			// RegPanel
			// 
			this.RegPanel.Controls.Add(this.R15Queue);
			this.RegPanel.Controls.Add(this.R14Queue);
			this.RegPanel.Controls.Add(this.R13Queue);
			this.RegPanel.Controls.Add(this.R12Queue);
			this.RegPanel.Controls.Add(this.R11Queue);
			this.RegPanel.Controls.Add(this.R10Queue);
			this.RegPanel.Controls.Add(this.R9Queue);
			this.RegPanel.Controls.Add(this.R8Queue);
			this.RegPanel.Controls.Add(this.R7Queue);
			this.RegPanel.Controls.Add(this.R6Queue);
			this.RegPanel.Controls.Add(this.R5Queue);
			this.RegPanel.Controls.Add(this.R4Queue);
			this.RegPanel.Controls.Add(this.R3Queue);
			this.RegPanel.Controls.Add(this.R2Queue);
			this.RegPanel.Controls.Add(this.Register15);
			this.RegPanel.Controls.Add(this.Register14);
			this.RegPanel.Controls.Add(this.Register13);
			this.RegPanel.Controls.Add(this.Register12);
			this.RegPanel.Controls.Add(this.Register11);
			this.RegPanel.Controls.Add(this.Register10);
			this.RegPanel.Controls.Add(this.Register9);
			this.RegPanel.Controls.Add(this.Register8);
			this.RegPanel.Controls.Add(this.Register7);
			this.RegPanel.Controls.Add(this.Register6);
			this.RegPanel.Controls.Add(this.Register5);
			this.RegPanel.Controls.Add(this.Register4);
			this.RegPanel.Controls.Add(this.Register3);
			this.RegPanel.Controls.Add(this.Register2);
			this.RegPanel.Controls.Add(this.Register1);
			this.RegPanel.Controls.Add(this.R1Queue);
			this.RegPanel.Location = new System.Drawing.Point(20, 142);
			this.RegPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.RegPanel.Name = "RegPanel";
			this.RegPanel.Size = new System.Drawing.Size(885, 300);
			this.RegPanel.TabIndex = 11;
			// 
			// R15Queue
			// 
			this.R15Queue.AutoSize = true;
			this.R15Queue.Enabled = false;
			this.R15Queue.Location = new System.Drawing.Point(807, 8);
			this.R15Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R15Queue.Name = "R15Queue";
			this.R15Queue.Size = new System.Drawing.Size(48, 20);
			this.R15Queue.TabIndex = 20;
			this.R15Queue.Text = "15: 00";
			this.R15Queue.Visible = true;
			// 
			// R14Queue
			// 
			this.R14Queue.AutoSize = true;
			this.R14Queue.Enabled = false;
			this.R14Queue.Location = new System.Drawing.Point(749, 8);
			this.R14Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R14Queue.Name = "R14Queue";
			this.R14Queue.Size = new System.Drawing.Size(48, 20);
			this.R14Queue.TabIndex = 20;
			this.R14Queue.Text = "14: 00";
			this.R14Queue.Visible = true;
			// 
			// R13Queue
			// 
			this.R13Queue.AutoSize = true;
			this.R13Queue.Enabled = false;
			this.R13Queue.Location = new System.Drawing.Point(692, 8);
			this.R13Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R13Queue.Name = "R13Queue";
			this.R13Queue.Size = new System.Drawing.Size(48, 20);
			this.R13Queue.TabIndex = 20;
			this.R13Queue.Text = "13: 00";
			this.R13Queue.Visible = true;
			// 
			// R12Queue
			// 
			this.R12Queue.AutoSize = true;
			this.R12Queue.Enabled = false;
			this.R12Queue.Location = new System.Drawing.Point(635, 8);
			this.R12Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R12Queue.Name = "R12Queue";
			this.R12Queue.Size = new System.Drawing.Size(48, 20);
			this.R12Queue.TabIndex = 20;
			this.R12Queue.Text = "12: 00";
			this.R12Queue.Visible = true;
			// 
			// R11Queue
			// 
			this.R11Queue.AutoSize = true;
			this.R11Queue.Enabled = false;
			this.R11Queue.Location = new System.Drawing.Point(577, 8);
			this.R11Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R11Queue.Name = "R11Queue";
			this.R11Queue.Size = new System.Drawing.Size(48, 20);
			this.R11Queue.TabIndex = 20;
			this.R11Queue.Text = "11: 00";
			this.R11Queue.Visible = true;
			// 
			// R10Queue
			// 
			this.R10Queue.AutoSize = true;
			this.R10Queue.Enabled = false;
			this.R10Queue.Location = new System.Drawing.Point(520, 8);
			this.R10Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R10Queue.Name = "R10Queue";
			this.R10Queue.Size = new System.Drawing.Size(48, 20);
			this.R10Queue.TabIndex = 19;
			this.R10Queue.Text = "10: 00";
			this.R10Queue.Visible = true;
			// 
			// R9Queue
			// 
			this.R9Queue.AutoSize = true;
			this.R9Queue.Enabled = false;
			this.R9Queue.Location = new System.Drawing.Point(463, 8);
			this.R9Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R9Queue.Name = "R9Queue";
			this.R9Queue.Size = new System.Drawing.Size(48, 20);
			this.R9Queue.TabIndex = 19;
			this.R9Queue.Text = "09: 00";
			this.R9Queue.Visible = true;
			// 
			// R8Queue
			// 
			this.R8Queue.AutoSize = true;
			this.R8Queue.Enabled = false;
			this.R8Queue.Location = new System.Drawing.Point(407, 8);
			this.R8Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R8Queue.Name = "R8Queue";
			this.R8Queue.Size = new System.Drawing.Size(48, 20);
			this.R8Queue.TabIndex = 19;
			this.R8Queue.Text = "08: 00";
			this.R8Queue.Visible = true;
			// 
			// R7Queue
			// 
			this.R7Queue.AutoSize = true;
			this.R7Queue.Enabled = false;
			this.R7Queue.Location = new System.Drawing.Point(347, 8);
			this.R7Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R7Queue.Name = "R7Queue";
			this.R7Queue.Size = new System.Drawing.Size(48, 20);
			this.R7Queue.TabIndex = 19;
			this.R7Queue.Text = "07: 00";
			this.R7Queue.Visible = true;
			// 
			// R6Queue
			// 
			this.R6Queue.AutoSize = true;
			this.R6Queue.Enabled = false;
			this.R6Queue.Location = new System.Drawing.Point(291, 8);
			this.R6Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R6Queue.Name = "R6Queue";
			this.R6Queue.Size = new System.Drawing.Size(48, 20);
			this.R6Queue.TabIndex = 19;
			this.R6Queue.Text = "06: 00";
			this.R6Queue.Visible = true;
			// 
			// R5Queue
			// 
			this.R5Queue.AutoSize = true;
			this.R5Queue.Enabled = false;
			this.R5Queue.Location = new System.Drawing.Point(233, 8);
			this.R5Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R5Queue.Name = "R5Queue";
			this.R5Queue.Size = new System.Drawing.Size(48, 20);
			this.R5Queue.TabIndex = 19;
			this.R5Queue.Text = "05: 00";
			this.R5Queue.Visible = true;
			// 
			// R4Queue
			// 
			this.R4Queue.AutoSize = true;
			this.R4Queue.Enabled = false;
			this.R4Queue.Location = new System.Drawing.Point(176, 8);
			this.R4Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R4Queue.Name = "R4Queue";
			this.R4Queue.Size = new System.Drawing.Size(48, 20);
			this.R4Queue.TabIndex = 19;
			this.R4Queue.Text = "04: 00";
			this.R4Queue.Visible = true;
			// 
			// R3Queue
			// 
			this.R3Queue.AutoSize = true;
			this.R3Queue.Enabled = false;
			this.R3Queue.Location = new System.Drawing.Point(117, 8);
			this.R3Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R3Queue.Name = "R3Queue";
			this.R3Queue.Size = new System.Drawing.Size(48, 20);
			this.R3Queue.TabIndex = 17;
			this.R3Queue.Text = "03: 00";
			this.R3Queue.Visible = true;
			// 
			// R2Queue
			// 
			this.R2Queue.AutoSize = true;
			this.R2Queue.Enabled = false;
			this.R2Queue.Location = new System.Drawing.Point(61, 8);
			this.R2Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R2Queue.Name = "R2Queue";
			this.R2Queue.Size = new System.Drawing.Size(48, 20);
			this.R2Queue.TabIndex = 16;
			this.R2Queue.Text = "02: 00";
			this.R2Queue.Visible = true;
			// 
			// Register15
			// 
			this.Register15.FormattingEnabled = true;
			this.Register15.ItemHeight = 20;
			this.Register15.Location = new System.Drawing.Point(807, 32);
			this.Register15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register15.Name = "Register15";
			this.Register15.Size = new System.Drawing.Size(48, 244);
			this.Register15.TabIndex = 15;
			this.Register15.Visible = true;
			// 
			// Register14
			// 
			this.Register14.FormattingEnabled = true;
			this.Register14.ItemHeight = 20;
			this.Register14.Location = new System.Drawing.Point(749, 32);
			this.Register14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register14.Name = "Register14";
			this.Register14.Size = new System.Drawing.Size(48, 244);
			this.Register14.TabIndex = 14;
			this.Register14.Visible = true;
			// 
			// Register13
			// 
			this.Register13.FormattingEnabled = true;
			this.Register13.ItemHeight = 20;
			this.Register13.Location = new System.Drawing.Point(692, 32);
			this.Register13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register13.Name = "Register13";
			this.Register13.Size = new System.Drawing.Size(48, 244);
			this.Register13.TabIndex = 13;
			this.Register13.Visible = true;
			// 
			// Register12
			// 
			this.Register12.FormattingEnabled = true;
			this.Register12.ItemHeight = 20;
			this.Register12.Location = new System.Drawing.Point(635, 32);
			this.Register12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register12.Name = "Register12";
			this.Register12.Size = new System.Drawing.Size(48, 244);
			this.Register12.TabIndex = 12;
			this.Register12.Visible = true;
			// 
			// Register11
			// 
			this.Register11.FormattingEnabled = true;
			this.Register11.ItemHeight = 20;
			this.Register11.Location = new System.Drawing.Point(577, 32);
			this.Register11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register11.Name = "Register11";
			this.Register11.Size = new System.Drawing.Size(48, 244);
			this.Register11.TabIndex = 11;
			this.Register11.Visible = true;
			// 
			// Register10
			// 
			this.Register10.FormattingEnabled = true;
			this.Register10.ItemHeight = 20;
			this.Register10.Location = new System.Drawing.Point(520, 32);
			this.Register10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register10.Name = "Register10";
			this.Register10.Size = new System.Drawing.Size(48, 244);
			this.Register10.TabIndex = 10;
			this.Register10.Visible = true;
			// 
			// Register9
			// 
			this.Register9.FormattingEnabled = true;
			this.Register9.ItemHeight = 20;
			this.Register9.Location = new System.Drawing.Point(463, 32);
			this.Register9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register9.Name = "Register9";
			this.Register9.Size = new System.Drawing.Size(48, 244);
			this.Register9.TabIndex = 9;
			this.Register9.Visible = true;
			// 
			// Register8
			// 
			this.Register8.FormattingEnabled = true;
			this.Register8.ItemHeight = 20;
			this.Register8.Location = new System.Drawing.Point(405, 32);
			this.Register8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register8.Name = "Register8";
			this.Register8.Size = new System.Drawing.Size(48, 244);
			this.Register8.TabIndex = 8;
			this.Register8.Visible = true;
			// 
			// Register7
			// 
			this.Register7.FormattingEnabled = true;
			this.Register7.ItemHeight = 20;
			this.Register7.Location = new System.Drawing.Point(348, 32);
			this.Register7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register7.Name = "Register7";
			this.Register7.Size = new System.Drawing.Size(48, 244);
			this.Register7.TabIndex = 7;
			this.Register7.Visible = true;
			// 
			// Register6
			// 
			this.Register6.FormattingEnabled = true;
			this.Register6.ItemHeight = 20;
			this.Register6.Location = new System.Drawing.Point(291, 32);
			this.Register6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register6.Name = "Register6";
			this.Register6.Size = new System.Drawing.Size(48, 244);
			this.Register6.TabIndex = 6;
			this.Register6.Visible = true;
			// 
			// Register5
			// 
			this.Register5.FormattingEnabled = true;
			this.Register5.ItemHeight = 20;
			this.Register5.Location = new System.Drawing.Point(233, 32);
			this.Register5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register5.Name = "Register5";
			this.Register5.Size = new System.Drawing.Size(48, 244);
			this.Register5.TabIndex = 5;
			this.Register5.Visible = true;
			// 
			// Register4
			// 
			this.Register4.FormattingEnabled = true;
			this.Register4.ItemHeight = 20;
			this.Register4.Location = new System.Drawing.Point(176, 32);
			this.Register4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register4.Name = "Register4";
			this.Register4.Size = new System.Drawing.Size(48, 244);
			this.Register4.TabIndex = 4;
			this.Register4.Visible = true;
			// 
			// Register3
			// 
			this.Register3.FormattingEnabled = true;
			this.Register3.ItemHeight = 20;
			this.Register3.Location = new System.Drawing.Point(119, 32);
			this.Register3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register3.Name = "Register3";
			this.Register3.Size = new System.Drawing.Size(48, 244);
			this.Register3.TabIndex = 3;
			this.Register3.Visible = true;
			// 
			// Register2
			// 
			this.Register2.FormattingEnabled = true;
			this.Register2.ItemHeight = 20;
			this.Register2.Location = new System.Drawing.Point(61, 32);
			this.Register2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register2.Name = "Register2";
			this.Register2.Size = new System.Drawing.Size(48, 244);
			this.Register2.TabIndex = 2;
			this.Register2.Visible = true;
			// 
			// Register1
			// 
			this.Register1.FormattingEnabled = true;
			this.Register1.ItemHeight = 20;
			this.Register1.Location = new System.Drawing.Point(4, 32);
			this.Register1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register1.Name = "Register1";
			this.Register1.Size = new System.Drawing.Size(48, 244);
			this.Register1.TabIndex = 1;
			this.Register1.Visible = true;
			// 
			// R1Queue
			// 
			this.R1Queue.AutoSize = true;
			this.R1Queue.Enabled = false;
			this.R1Queue.Location = new System.Drawing.Point(5, 8);
			this.R1Queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.R1Queue.Name = "R1Queue";
			this.R1Queue.Size = new System.Drawing.Size(48, 20);
			this.R1Queue.TabIndex = 0;
			this.R1Queue.Text = "01: 00";
			this.R1Queue.Visible = true;
			// 
			// LQLabel
			// 
			this.LQLabel.AutoSize = true;
			this.LQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.LQLabel.Location = new System.Drawing.Point(20, 458);
			this.LQLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LQLabel.Name = "LQLabel";
			this.LQLabel.Size = new System.Drawing.Size(110, 17);
			this.LQLabel.TabIndex = 12;
			this.LQLabel.Text = "Longest Queue:";
			// 
			// LQueue
			// 
			this.LQueue.AutoSize = true;
			this.LQueue.Location = new System.Drawing.Point(171, 455);
			this.LQueue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LQueue.Name = "LQueue";
			this.LQueue.Size = new System.Drawing.Size(17, 20);
			this.LQueue.TabIndex = 13;
			this.LQueue.Text = "0";
			// 
			// CALabel
			// 
			this.CALabel.AutoSize = true;
			this.CALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.CALabel.Location = new System.Drawing.Point(20, 479);
			this.CALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CALabel.Name = "CALabel";
			this.CALabel.Size = new System.Drawing.Size(128, 17);
			this.CALabel.TabIndex = 14;
			this.CALabel.Text = "Customers Arrived:";
			// 
			// CArrived
			// 
			this.CArrived.AutoSize = true;
			this.CArrived.Location = new System.Drawing.Point(171, 478);
			this.CArrived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CArrived.Name = "CArrived";
			this.CArrived.Size = new System.Drawing.Size(17, 20);
			this.CArrived.TabIndex = 15;
			this.CArrived.Text = "0";
			// 
			// CDLabel
			// 
			this.CDLabel.AutoSize = true;
			this.CDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.CDLabel.Location = new System.Drawing.Point(20, 502);
			this.CDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CDLabel.Name = "CDLabel";
			this.CDLabel.Size = new System.Drawing.Size(142, 17);
			this.CDLabel.TabIndex = 16;
			this.CDLabel.Text = "Customers Departed:";
			// 
			// CDeparted
			// 
			this.CDeparted.AutoSize = true;
			this.CDeparted.Location = new System.Drawing.Point(171, 501);
			this.CDeparted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CDeparted.Name = "CDeparted";
			this.CDeparted.Size = new System.Drawing.Size(17, 20);
			this.CDeparted.TabIndex = 17;
			this.CDeparted.Text = "0";
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(847, 468);
			this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(59, 55);
			this.ExitBtn.TabIndex = 18;
			this.ExitBtn.Text = "Exit";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// AvgLabel
			// 
			this.AvgLabel.AutoSize = true;
			this.AvgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.AvgLabel.Location = new System.Drawing.Point(308, 456);
			this.AvgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.AvgLabel.Name = "AvgLabel";
			this.AvgLabel.Size = new System.Drawing.Size(165, 17);
			this.AvgLabel.TabIndex = 19;
			this.AvgLabel.Text = "Average Customer Total:";
			// 
			// AvgTotal
			// 
			this.AvgTotal.AutoSize = true;
			this.AvgTotal.Location = new System.Drawing.Point(482, 455);
			this.AvgTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.AvgTotal.Name = "AvgTotal";
			this.AvgTotal.Size = new System.Drawing.Size(17, 20);
			this.AvgTotal.TabIndex = 20;
			this.AvgTotal.Text = "0";
			// 
			// MinLabel
			// 
			this.MinLabel.AutoSize = true;
			this.MinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.MinLabel.Location = new System.Drawing.Point(308, 479);
			this.MinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.MinLabel.Name = "MinLabel";
			this.MinLabel.Size = new System.Drawing.Size(167, 17);
			this.MinLabel.TabIndex = 21;
			this.MinLabel.Text = "Minimum Customer Total:";
			// 
			// MinTotal
			// 
			this.MinTotal.AutoSize = true;
			this.MinTotal.Location = new System.Drawing.Point(482, 478);
			this.MinTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.MinTotal.Name = "MinTotal";
			this.MinTotal.Size = new System.Drawing.Size(17, 20);
			this.MinTotal.TabIndex = 22;
			this.MinTotal.Text = "0";
			// 
			// MaxLabel
			// 
			this.MaxLabel.AutoSize = true;
			this.MaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.MaxLabel.Location = new System.Drawing.Point(308, 502);
			this.MaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.MaxLabel.Name = "MaxLabel";
			this.MaxLabel.Size = new System.Drawing.Size(170, 17);
			this.MaxLabel.TabIndex = 23;
			this.MaxLabel.Text = "Maximum Customer Total:";
			// 
			// MaxTotal
			// 
			this.MaxTotal.AutoSize = true;
			this.MaxTotal.Location = new System.Drawing.Point(482, 501);
			this.MaxTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.MaxTotal.Name = "MaxTotal";
			this.MaxTotal.Size = new System.Drawing.Size(17, 20);
			this.MaxTotal.TabIndex = 24;
			this.MaxTotal.Text = "0";
			// 
			// TotalSales
			// 
			this.TotalSales.AutoSize = true;
			this.TotalSales.Location = new System.Drawing.Point(628, 456);
			this.TotalSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TotalSales.Name = "TotalSales";
			this.TotalSales.Size = new System.Drawing.Size(17, 20);
			this.TotalSales.TabIndex = 26;
			this.TotalSales.Text = "0";
			// 
			// TotalSalesLabel
			// 
			this.TotalSalesLabel.AutoSize = true;
			this.TotalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.TotalSalesLabel.Location = new System.Drawing.Point(538, 458);
			this.TotalSalesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TotalSalesLabel.Name = "TotalSalesLabel";
			this.TotalSalesLabel.Size = new System.Drawing.Size(83, 17);
			this.TotalSalesLabel.TabIndex = 25;
			this.TotalSalesLabel.Text = "Total Sales:";
			// 
			// Simulation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(921, 549);
			this.Controls.Add(this.TotalSales);
			this.Controls.Add(this.TotalSalesLabel);
			this.Controls.Add(this.MaxTotal);
			this.Controls.Add(this.MaxLabel);
			this.Controls.Add(this.MinTotal);
			this.Controls.Add(this.MinLabel);
			this.Controls.Add(this.AvgTotal);
			this.Controls.Add(this.AvgLabel);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.CDeparted);
			this.Controls.Add(this.CDLabel);
			this.Controls.Add(this.CArrived);
			this.Controls.Add(this.CALabel);
			this.Controls.Add(this.LQueue);
			this.Controls.Add(this.LQLabel);
			this.Controls.Add(this.RegPanel);
			this.Controls.Add(this.RegPanelLabel);
			this.Controls.Add(this.RunBtn);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Simulation";
			this.Text = "Supermarket Simulation";
			this.RegPanel.ResumeLayout(false);
			this.RegPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Label RegPanelLabel;
        private System.Windows.Forms.Panel RegPanel;
        private System.Windows.Forms.Label LQLabel;
        private System.Windows.Forms.Label LQueue;
        private System.Windows.Forms.Label CALabel;
        private System.Windows.Forms.Label CArrived;
        private System.Windows.Forms.Label CDLabel;
        private System.Windows.Forms.Label CDeparted;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ListBox Register15;
        private System.Windows.Forms.ListBox Register14;
        private System.Windows.Forms.ListBox Register13;
        private System.Windows.Forms.ListBox Register12;
        private System.Windows.Forms.ListBox Register11;
        private System.Windows.Forms.ListBox Register10;
        private System.Windows.Forms.ListBox Register9;
        private System.Windows.Forms.ListBox Register8;
        private System.Windows.Forms.ListBox Register7;
        private System.Windows.Forms.ListBox Register6;
        private System.Windows.Forms.ListBox Register5;
        private System.Windows.Forms.ListBox Register4;
        private System.Windows.Forms.ListBox Register3;
        private System.Windows.Forms.ListBox Register2;
        private System.Windows.Forms.ListBox Register1;
        private System.Windows.Forms.Label R1Queue;
        private System.Windows.Forms.Label R15Queue;
        private System.Windows.Forms.Label R14Queue;
        private System.Windows.Forms.Label R13Queue;
        private System.Windows.Forms.Label R12Queue;
        private System.Windows.Forms.Label R11Queue;
        private System.Windows.Forms.Label R10Queue;
        private System.Windows.Forms.Label R9Queue;
        private System.Windows.Forms.Label R8Queue;
        private System.Windows.Forms.Label R7Queue;
        private System.Windows.Forms.Label R6Queue;
        private System.Windows.Forms.Label R5Queue;
        private System.Windows.Forms.Label R4Queue;
        private System.Windows.Forms.Label R3Queue;
        private System.Windows.Forms.Label R2Queue;
        private System.Windows.Forms.Label AvgLabel;
        private System.Windows.Forms.Label AvgTotal;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MinTotal;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MaxTotal;
		private Label TotalSales;
		private Label TotalSalesLabel;
	}
}