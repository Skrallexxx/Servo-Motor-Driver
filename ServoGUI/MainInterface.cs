using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace ServoController
{
    public partial class MainInterface : Form
    {
        // Holds the values that are plotted each time the control graph 1 is updated.
        private List<int> time_graph_values = new List<int>();
        // Determines how many of the previous points are plotted.
        private int length = 250;
        // Hold all the states from inputs_outputs class

        List<Signal> SigList = new List<Signal>();


        private int tick;

        public MainInterface()
        {
            InitializeComponent();

            Resize += frmGraphing_Resize;

            // Add any initialization after the InitializeComponent() call.
            setupControlGraphs(time_graph);
            // populate the all the states into the context menus
            populate_contextmenu1_dropdown_states();

            //Stores the current tickcount
            tick = Environment.TickCount;


        }

        public void AddCurve_To_Plot(ZedGraphControl zgc, string new_name, Color Colour, string new_units)
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

        public void delete_all_curves_from_Plot(ZedGraphControl zgc)
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

        private object curve_exists_in_graph(ZedGraphControl zgc, ref string curve_name)
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

        public string[] selected_sigs = new string[1];
        public int selected_cnt = 0;

        public bool graph = false;


        private void ContextMenuStrip1_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            //Get the text of the item that was clicked on.
            ToolStripItem clickedItem;
            clickedItem = e.ClickedItem;
            string signalName = e.ClickedItem.Text;
            bool itemChecked = e.ClickedItem.Selected;

            selected_cnt = 0;
            graph = true;

            // Have to check each strip item Checked parameter to see if a filter should be added or removed.
            // Windows doesn't have a Checked attribute for the clicked item which is why this code is akward.
            foreach (ToolStripItem stripItem in contextMenuStrip1.Items)
            {
                if (stripItem.Name == signalName)
                {
                    // Strip item checked parameter hasn't been updated yet so if its false then that means we will add a filter
                    if (itemChecked == false)
                    {
                        // Check if the state is already being plotted 
                        if (curve_exists_in_graph(time_graph, ref signalName) == null)
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
                if (itemChecked == true)
                {
                    Array.Resize(ref selected_sigs, selected_cnt + 1);
                    selected_sigs[selected_cnt] = signalName;
                    selected_cnt += 1;
                }
            }
        }
 
        private void PlotGraphsTimer_Tick(object sender, EventArgs e)
        {

            //update_vals();

            // This function calls the redraw of all the graphs with the provided states.
            display_graph(time_graph, ref SigList);

            

        }

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

        private void btn_select_yaxis_states_Click(object sender, EventArgs e)
        {
            //populate_contextmenu1_dropdown_states()
            // Show the contextstrip menu which allows a bandpass filter to be added to each state
            contextMenuStrip1.Show(btn_select_yaxis_states, 0, btn_select_yaxis_states.Height);
        }

        private void update_vals()
        {
            /*UPDATE VALUES*/
            /*Check MCU for new values*/
        }
    }
}

class Signal
{
    public string Name;
    public double Value;
    public string Units;

    public Signal()
    {
        Name = "Defaul";
        Value = 0.0;
        Units = "Default";
    }
}
