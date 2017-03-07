using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using static ServoMotorDriver.ControlEnums;
using ZedGraph;
using System.Drawing;
using System.Collections.Generic;

namespace ServoMotorDriver {
    public partial class MainInterface : Form {

        #region Variables and Control/Communication Properties
        // Received inputs and outgoing outputs
        private int Input = 0;
        private byte[] Inputs = new byte[4];
        private byte[] Outputs = new byte[4];

        // Current selected mode and direction
        MODE currentMode = MODE.FREESPIN;
        DIRECTION currentDirection = DIRECTION.CLOCKWISE;

        // Transmission constants
        private const byte START = 255, ZERO = 0;

        // DAC Object
        private DAC dac = new DAC();

        #endregion

        #region Interface Intialization
        // Interface intiialization method
        public MainInterface() {
            Debug.WriteLine("Servo Motor Driver Starting Up...");
            InitializeComponent();

            // Add the MODE enums to the dropdown mode selection box
            foreach(MODE mode in Enum.GetValues(typeof(MODE))) {
                ModeSelectionBox.Items.Add(GetAttribute(mode).disp);
            }
            WriteMessage("Added Mode Selection Options");

            // Add the DIRECTION enums to the dropdown direction selection box
            foreach(DIRECTION direction in Enum.GetValues(typeof(DIRECTION))) {
                DirectionSelectionBox.Items.Add(GetAttribute(direction).disp);
            }
            WriteMessage("Added Direction Selection Options");

            // Add available COM ports to the dropdown port selection box
            ComPortSelectionBox.DataSource = SerialPort.GetPortNames();
            WriteMessage("Added COM Port Selection Options");

            // Establish connection using selected COM port
            if (ComPortSelectionBox.Items.Count > 0)
                TryOpenSerialCommunication(ComPortSelectionBox.SelectedItem.ToString());
            else WriteError("No Available COM Ports");

            // Graphing initialisation
            setupControlGraphs(time_graph);
            populate_contextmenu1_dropdown_states();

            //Stores the current tickcount
            tick = Environment.TickCount;
        }

        #endregion

        #region Program Loop

        // Send-Recieve method, runs every 10 ticks
        private void SendReceiveUpdate(object sender, EventArgs e) {

        }

        #endregion

        #region Communication Send/Receive

        void TryOpenSerialCommunication(string portName, bool reOpen = false) {
            // Check if the bluetooth has been connected
            if (SerialComPort.PortName == portName && SerialComPort.IsOpen) {
                WriteMessage("Communication is already established on the selected COM port");
                return;
            }
            if (reOpen = true && SerialComPort.IsOpen)
                SerialComPort.Close();
            if (!SerialComPort.IsOpen) {
                if (portName.Length == 0)
                    return;
                SerialComPort.PortName = portName;
                try {
                    //Try to connect to the bluetooth
                    WriteMessage("Attempting to open communication on " + portName);
                    SerialComPort.Open();
                    WriteMessage("Communication successfully opened on " + portName);
                }
                catch {
                    //If the bluetooth does not connect return an error
                    WriteError("Failed to open communication on " + portName);
                }
            }
        }

        #endregion

        #region Interface Helper Methods

        // Called when the COM port selection is changed, updates COM port in use for serial communication
        private void OnComPortSelectionChanged(object sender, EventArgs e) {
            WriteMessage("COM Port selection modified, updating serial communication");
            TryOpenSerialCommunication(ComPortSelectionBox.SelectedItem.ToString(), true);
        }

        private void OnModeSelectionChanged(object sender, EventArgs e) {
            foreach(MODE mode in Enum.GetValues(typeof(MODE))) {
                if(ModeSelectionBox.Text == GetAttribute(mode).disp) {
                    currentMode = mode;
                    break;
                }
            }
            WriteMessage("Selected mode updated to " + GetAttribute(currentMode).disp);
        }

        private void OnDirectionSelectionChanged(object sender, EventArgs e) {
            foreach(DIRECTION direction in Enum.GetValues(typeof(DIRECTION))) {
                if(DirectionSelectionBox.Text == GetAttribute(direction).disp) {
                    currentDirection = direction;
                    break;
                }
            }
            WriteMessage("Selected direction updated to " + GetAttribute(currentDirection).disp);
        }

        #endregion

        #region Debugging
        // Writes a non-error info message to the interface and the console output
        private void WriteMessage(string message) {
            Debug.WriteLine("\t" + message);
            MessageLogStatusStrip.Text = message;
        }

        // Writes an error message to the interface and the console output
        private void WriteError(string message) {
            Debug.WriteLine("\t[ERROR] " + message);
            MessageLogStatusStrip.Text = message;
        }
        #endregion

        #region Graphing

        #region Graphing - Variables and List initialisation

        //List containing the graphed values
        private List<int> time_graph_values = new List<int>();

        // Determines how many of the previous points are plotted.
        private int length = 250;

        // Hold all the states from inputs_outputs class
        List<Signal> SigList = new List<Signal>();

        //Environment tick count
        private int tick;

        #endregion

        #region Graphing - Methods

        private void AddCurve_To_Plot(ZedGraphControl zgc, string new_name, Color Colour, string new_units)
        {
            GraphPane myPane = zgc.GraphPane;
            int new_yaxis = 0;
            // If a curve already exists then add a new Yaxis
            if (myPane.CurveList.Count > 0)
            {
                // Add the new curve with a new Y axis
                new_yaxis = myPane.AddYAxis(new_name + " " + new_units);
            }
            else
            {
                myPane.YAxis.Title.Text = new_name + " " + new_units;
            }

            // Add a new curve to the graph
            RollingPointPairList curve_list = new RollingPointPairList(length);
            LineItem curve = new LineItem(new_name, curve_list, Colour, SymbolType.None);
            curve.YAxisIndex = new_yaxis;

            myPane.CurveList.Add(curve);


        }

        private void delete_all_curves_from_Plot(ZedGraphControl zgc)
        {
            // delete all the curves from the graph
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.YAxisList.Clear();

        }

        private void setupControlGraphs(ZedGraphControl zgc)
        {
            // Initialse the graphs to defaut values.
            GraphPane myPane = zgc.GraphPane;
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 30;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 2;
            myPane.YAxis.Scale.Min = -100;
            myPane.YAxis.Scale.Max = 100;
            myPane.YAxis.Scale.MinorStep = 10;
            myPane.YAxis.Scale.MajorStep = 50;
            // Scale the axes
            zgc.AxisChange();

        }

        private Signal GetSignalFromName(string signalName)
        {
            Signal foundSignal = new Signal();

            foreach (Signal aSignal in SigList)
            {
                if (aSignal.Name == signalName)
                {
                    foundSignal = aSignal;
                    return foundSignal;
                }
            }
            // The state was not found in all states
            // this returns a Default state
            return foundSignal;
        }


        private void display_graph(ZedGraphControl zgc, ref List<Signal> plotValues)
        {
            GraphPane myPane = zgc.GraphPane;

            // Time is measured in seconds. It is from when the global inputs and outputs class was started.
            double time = (Environment.TickCount - tick) / 1000.0;

            IPointListEdit curvePoints;

            // For each curve get the new state value to plot
            foreach (CurveItem Curve in myPane.CurveList)
            {
                foreach (Signal aSignal in plotValues)
                {
                    if (Curve.Label.Text == aSignal.Name)
                    {
                        curvePoints = Curve.Points as IPointListEdit;
                        // Add the newest state value to the list of points to plot
                        curvePoints.Add(time, aSignal.Value);
                        // Update the list of points to plot
                        Curve.Points = curvePoints;
                    }
                }
            }

            // major step between the max X value and the end of the axis
            Scale xScale = zgc.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = xScale.Max + xScale.MajorStep;
                //xScale.Min = xScale.Max - xScale.MajorStep
                xScale.Min = xScale.Min + xScale.MajorStep;
            }

            // Make sure the Y axis is rescaled to accommodate actual data
            zgc.AxisChange();
            // Force a redraw
            zgc.Invalidate();
        }


        private void populate_contextmenu1_dropdown_states()
        {
            // Clear the states and readd them

            //Calls the function to populate the CAN signals
            SigList = get_sig_list(SigList);

            foreach (Signal aSignal in SigList)
            {
                // Check if the signal already exists
                ToolStripItem toolStrip_matched_state;

                toolStrip_matched_state = contextMenuStrip1.Items[aSignal.Name];


                if (toolStrip_matched_state == null)
                {
                    // Create a new drop down item and add it to the conxt menu strip 1
                    ToolStripMenuItem new_drop_down_item = new ToolStripMenuItem();
                    new_drop_down_item.Name = aSignal.Name;
                    new_drop_down_item.Text = aSignal.Name;
                    new_drop_down_item.CheckOnClick = true;
                    new_drop_down_item.Checked = false;
                    contextMenuStrip1.Items.Add(new_drop_down_item);
                }

            }

        }

        private bool curve_exists_in_graph(ZedGraphControl zgc, ref string curve_name)
        {
            // check a graphs curve list for a curve wiuth the name curve_name
            GraphPane myPane = zgc.GraphPane;
            // For each curve get the new state value to plot
            foreach (CurveItem Curve in myPane.CurveList)
            {
                if (Curve.Label.Text == curve_name)
                {
                    return true;
                }
            }
            return false;
        }

        private void delete_curve_from_Plot(ZedGraphControl zgc, ref string curve_name)
        {
            // check a graphs curve list for a curve with the name curve_name
            GraphPane myPane = zgc.GraphPane;
            // For each curve get the new state value to plot
            foreach (CurveItem Curve in myPane.CurveList)
            {
                if (Curve.Label.Text == curve_name)
                {
                    if (Curve.YAxisIndex < myPane.YAxisList.Count & myPane.YAxisList.Count > 1)
                    {
                        myPane.YAxisList.RemoveAt(Curve.YAxisIndex);
                    }
                    myPane.CurveList.Remove(Curve);
                    break; // TODO: might not be correct. Was : Exit For
                }
            }
        }

        #endregion

        #region Graphing - Buttons

        private void btn_select_yaxis_states_Click(object sender, EventArgs e)
        {
            // Show the contextstrip menu which allows a bandpass filter to be added to each state
            contextMenuStrip1.Show(btn_select_yaxis_states, 0, btn_select_yaxis_states.Height);
            contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStrip1_Click);
        }

        private void ContextMenuStrip1_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            // Stop the context menu from closing when an item is clicked. 
            // This is done so a user can select multiple items without having
            // to reopen the context menu.
            if ((e.CloseReason == ToolStripDropDownCloseReason.ItemClicked))
            {
                e.Cancel = true;
            }
        }

        public string[] selected_sigs;
        public int selected_cnt = 0;

        public bool graph = false;


        private void contextMenuStrip1_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            //Get the text of the item that was clicked on.
            var clickedItem = e.ClickedItem;
            string signalName = clickedItem.Text;
            bool itemChecked = clickedItem.Selected;

            selected_cnt = 0;
            graph = true;

            // Have to check each strip item Checked parameter to see if a filter should be added or removed.
            // Windows doesn't have a Checked attribute for the clicked item which is why this code is akward.
            foreach (ToolStripItem stripItem in contextMenuStrip1.Items)
            {
                if (stripItem.Name == signalName)
                {
                    // Strip item checked parameter hasn't been updated yet so if its false then that means we will add a filter
                    if (itemChecked == true)
                    {
                        // Check if the state is already being plotted 
                        if (curve_exists_in_graph(time_graph, ref signalName) == false)
                        {
                            // Get the state from all states list
                            string state_units = GetSignalFromName(signalName).Units;

                            // Generate a random color
                            Color col = default(Color);
                            Random rndColor = new Random();
                            col = Color.FromArgb(rndColor.Next(255), rndColor.Next(255), rndColor.Next(255));

                            // Add this curve to the graph with the random color
                            AddCurve_To_Plot(time_graph, signalName, col, state_units);
                        }
                        Array.Resize(ref selected_sigs, selected_cnt + 1);
                        selected_sigs[selected_cnt] = signalName;
                        selected_cnt += 1;
                    }
                    else
                    {
                        // Delete this curve from the graph
                        delete_curve_from_Plot(time_graph, ref signalName);
                    }
                }
                if (itemChecked == false)
                {
                    Array.Resize(ref selected_sigs, selected_cnt + 1);
                    selected_sigs[selected_cnt] = signalName;
                    selected_cnt -= 1;
                }
            }
        }

        #endregion

        #region Graphing - Timers

        private void PlotGraphsTimer_Tick(object sender, EventArgs e)
        {

            //update_vals();

            // This function calls the redraw of all the graphs with the provided states.
            display_graph(time_graph, ref SigList);
        }

        #endregion

        #region Graphing - Form Functions

        private void frmGraphing_Resize(object sender, EventArgs e)
        {
            // Set the size of the graph
            SetSize();
            // Reposition buttons
            reposition_buttons();
        }

        // SetSize() is separate from Resize() so we can 
        //call it independently from the Form1_Load() method
        //This leaves a 10 px margin around the outside of the control
        //Customize this to fit your needs
        private void SetSize()
        {
            time_graph.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            time_graph.Size = new Size(ClientRectangle.Width - 20, ClientRectangle.Height - 60);
        }


        private void reposition_buttons()
        {
        }

        #endregion

        #region Graphing - Siganls & Values
        private List<Signal> get_sig_list(List<Signal> SigLists)
        {
            /*Add other signals to list as needed*/
            string[] Sig = { "Motor_Speed", "Motor_Position" };
            string[] Unit = { "RPM", "Degrees" };

            //Construct the signal list
            for (int il = 0; il < Sig.Length; il += 1)
            {
                SigList.Add(new Signal());
                SigList[il].Name = Sig[il];
                SigList[il].Units = Unit[il];
            }
            return SigLists;
        }
        private void update_vals()
        {
            /*UPDATE VALUES*/
            /*Check MCU for new values*/
        }

        #endregion
        #endregion
    }
}
