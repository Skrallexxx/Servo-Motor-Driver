using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using LiveCharts.Geared;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace ServoMotorDriver {
    public partial class GraphingForm : Form {
        // Chart values, mappers and series
        public GearedValues<GraphingEntry> series1Values = new GearedValues<GraphingEntry>();
        public GearedValues<GraphingEntry> series2Values = new GearedValues<GraphingEntry>();
        public GearedValues<GraphingLine> setLine1Values = new GearedValues<GraphingLine>();
        public GearedValues<GraphingLine> setLine2Values = new GearedValues<GraphingLine>();
        public GearedValues<GraphingLine> setLine3Values = new GearedValues<GraphingLine>();
        CartesianMapper<GraphingEntry> series1Mapper = Mappers.Xy<GraphingEntry>();
        CartesianMapper<GraphingEntry> series2Mapper = Mappers.Xy<GraphingEntry>();
        CartesianMapper<GraphingLine> lineMapper = Mappers.Xy<GraphingLine>();
        LineSeries series1;
        LineSeries series2;
        LineSeries setLine1;
        LineSeries setLine2;
        LineSeries setLine3;

        // Current interface-selected axes and units
        public ControlEnums.AXISOPTIONS currentXAxis = ControlEnums.AXISOPTIONS.TIME;
        public ControlEnums.AXISOPTIONS currentYAxis1 = ControlEnums.AXISOPTIONS.POSITION;
        public ControlEnums.AXISOPTIONS currentYAxis2 = ControlEnums.AXISOPTIONS.VELOCITY;
        public Enum currentXAxisUnit = ControlEnums.TIMEUNITS.SECONDS;
        public Enum currentYAxis1Unit = ControlEnums.BASEUNITS.COUNTS;
        public Enum currentYAxis2Unit = ControlEnums.BASEUNITS.COUNTS;

        // Set point variables
        public static double positionLineY = 0.0;
        public static double velocityLineY = 0.0;
        public static double accelerationLineY = 0.0;

        int numDataPoints = 300;

        public GraphingForm() {
            InitializeComponent();
            MainInterface.graphingOpen = true;

            // Populate the axes selection boxes
            foreach (ControlEnums.AXISOPTIONS axis in Enum.GetValues(typeof(ControlEnums.AXISOPTIONS))) {
                XAxisSelectionBox.Items.Add(ControlEnums.GetAttribute(axis).disp);
                YAxis1SelectionBox.Items.Add(ControlEnums.GetAttribute(axis).disp);
                YAxis2SelectionBox.Items.Add(ControlEnums.GetAttribute(axis).disp);
            }
            XAxisSelectionBox.SelectedIndex = 0;
            YAxis1SelectionBox.SelectedIndex = 3;
            YAxis2SelectionBox.SelectedIndex = 4;

            // Create the mappers for the 3 series
            series1Mapper = Mappers.Xy<GraphingEntry>().X(entry => entry.uptime / 1000.0).Y(entry => entry.position);
            series2Mapper = Mappers.Xy<GraphingEntry>().X(entry => entry.uptime / 1000.0).Y(entry => entry.velocity);
            lineMapper = Mappers.Xy<GraphingLine>().X(line => line.uptime / 1000.0).Y(line => line.y);

            series1 = new LineSeries(series1Mapper) { Values = series1Values, PointGeometrySize = 2, StrokeThickness = 2, Fill = System.Windows.Media.Brushes.Transparent };
            series2 = new LineSeries(series2Mapper) { Values = series2Values, PointGeometrySize = 2, StrokeThickness = 2, Fill = System.Windows.Media.Brushes.Transparent };
            setLine1 = new LineSeries(lineMapper) { Values = setLine1Values, PointGeometrySize = 2, StrokeThickness = 2, Fill = System.Windows.Media.Brushes.Transparent,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 33, 149, 242)), StrokeDashArray = new System.Windows.Media.DoubleCollection { 2 } };
            setLine2 = new LineSeries(lineMapper) { Values = setLine2Values, PointGeometrySize = 2, StrokeThickness = 2, Fill = System.Windows.Media.Brushes.Transparent, 
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 243, 67, 54)), StrokeDashArray = new System.Windows.Media.DoubleCollection { 2 } };
            setLine3 = new LineSeries(lineMapper) { Values = setLine3Values, PointGeometrySize = 2, StrokeThickness = 2, Fill = System.Windows.Media.Brushes.Transparent,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 243, 67, 54)), StrokeDashArray = new System.Windows.Media.DoubleCollection { 2 } };

            // Create the chart series
            Chart.Series = new SeriesCollection { series1, series2, setLine1, setLine2 };

            // Chart option setup
            Chart.DisableAnimations = true;
            //Chart.Hoverable = false;
            Chart.DataTooltip = null;
            series1Values.WithQuality(Quality.Medium);
            series2Values.WithQuality(Quality.Medium);
            setLine1Values.WithQuality(Quality.Low);
            setLine2Values.WithQuality(Quality.Low);
            setLine3Values.WithQuality(Quality.Low);

            pictureBox1.BackColor = Color.FromArgb(255, 33, 149, 242);
            pictureBox2.BackColor = Color.FromArgb(255, 243, 67, 54);
            GraphPeriodTextBox.Text = (double)(DataPointsUpDown.Value * (MainInterface.instance.ProgramLoopTimer.Interval / 1000.0m)) + " s";
        }

        public void AddGraphingEntry(GraphingEntry entry) {
            if (Series1EnabledCheckbox.Checked) {
                series1Values.Add(entry);

                if (currentYAxis1 == ControlEnums.AXISOPTIONS.POSITION)
                    setLine1Values.Add(new GraphingLine(entry.uptime, positionLineY));
                if (currentYAxis1 == ControlEnums.AXISOPTIONS.VELOCITY)
                    setLine1Values.Add(new GraphingLine(entry.uptime, velocityLineY));
                if (currentYAxis1 == ControlEnums.AXISOPTIONS.ACCELERATION) {
                    setLine1Values.Add(new GraphingLine(entry.uptime, accelerationLineY));
                    setLine3Values.Add(new GraphingLine(entry.uptime, -accelerationLineY));
                    setLine3.Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 33, 149, 242));
                }
            }
            if (Series2EnabledCheckbox.Checked) {
                series2Values.Add(entry);

                if (currentYAxis2 == ControlEnums.AXISOPTIONS.POSITION)
                    setLine2Values.Add(new GraphingLine(entry.uptime, positionLineY));
                if (currentYAxis2 == ControlEnums.AXISOPTIONS.VELOCITY)
                    setLine2Values.Add(new GraphingLine(entry.uptime, velocityLineY));
                if (currentYAxis2 == ControlEnums.AXISOPTIONS.ACCELERATION) {
                    setLine2Values.Add(new GraphingLine(entry.uptime, accelerationLineY));
                    setLine3Values.Add(new GraphingLine(entry.uptime, -accelerationLineY));
                    setLine3.Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 243, 67, 54));
                }
            }

            if (series1Values.Count > numDataPoints) series1Values.RemoveAt(0);
            if (setLine1Values.Count > numDataPoints) setLine1Values.RemoveAt(0);
            if (series2Values.Count > numDataPoints) series2Values.RemoveAt(0);
            if (setLine2Values.Count > numDataPoints) setLine2Values.RemoveAt(0);
            if (setLine3Values.Count > numDataPoints) setLine3Values.RemoveAt(0);
        }

        #region Interface Helper Methods
        // Called when the x-axis selection is changed. Updates the plotting mapper also
        private void OnXAxisSelectionChanged(object sender, EventArgs e) {
            currentXAxis = (ControlEnums.AXISOPTIONS)FindSelectedTextInEnum(XAxisSelectionBox.Text, typeof(ControlEnums.AXISOPTIONS));

            // Populate the unit selection box with available units
            XAxisUnitSelectionBox.Items.Clear();
            foreach (Enum unit in Enum.GetValues(ControlEnums.GetAttribute(currentXAxis).units.GetType()))
                XAxisUnitSelectionBox.Items.Add(ControlEnums.GetAttribute(unit).disp);
            XAxisUnitSelectionBox.SelectedIndex = 0;

            // Update mapper based on selected axis and unit
            if (currentXAxis == ControlEnums.AXISOPTIONS.TIME)
                CalculateTimeUnitConversion(series1Mapper, (ControlEnums.TIMEUNITS)currentXAxisUnit, true);
            else if (currentXAxis == ControlEnums.AXISOPTIONS.VOLTAGE)
                CalculateVoltageUnitConversion(series1Mapper, (ControlEnums.VOLTAGEUNITS)currentXAxisUnit, true);
            else CalculateBaseUnitConversion(series1Mapper, currentXAxis, (ControlEnums.BASEUNITS)currentXAxisUnit, true);
            WipeGraph();
        }

        // Called when the y-axis selection changes. Updates the plotting mapper also
        private void OnYAxis1SelectionChanged(object sender, EventArgs e) {
            currentYAxis1 = (ControlEnums.AXISOPTIONS)FindSelectedTextInEnum(YAxis1SelectionBox.Text, typeof(ControlEnums.AXISOPTIONS));

            // Populate unit selection box with available units
            YAxis1UnitSelectionBox.Items.Clear();
            foreach (Enum unit in Enum.GetValues(ControlEnums.GetAttribute(currentYAxis1).units.GetType()))
                YAxis1UnitSelectionBox.Items.Add(ControlEnums.GetAttribute(unit).disp);
            YAxis1UnitSelectionBox.SelectedIndex = 0;

            // Update mapper based on selected axis and unit
            if (currentYAxis1 == ControlEnums.AXISOPTIONS.TIME)
                CalculateTimeUnitConversion(series1Mapper, (ControlEnums.TIMEUNITS)currentYAxis1Unit, false);
            else if (currentYAxis1 == ControlEnums.AXISOPTIONS.VOLTAGE)
                CalculateVoltageUnitConversion(series1Mapper, (ControlEnums.VOLTAGEUNITS)currentYAxis1Unit, false);
            else CalculateBaseUnitConversion(series1Mapper, currentYAxis1, (ControlEnums.BASEUNITS)currentYAxis1Unit, false);

            if (currentYAxis1 == ControlEnums.AXISOPTIONS.ACCELERATION && Series1EnabledCheckbox.Checked) {
                Chart.Series.Add(setLine3);
            }
            else if (Chart.Series.Contains(setLine3))
                Chart.Series.Remove(setLine3);
            WipeGraph();
        }

        private void OnYAxis2SelectionChanged(object sender, EventArgs e) {
            currentYAxis2 = (ControlEnums.AXISOPTIONS)FindSelectedTextInEnum(YAxis2SelectionBox.Text, typeof(ControlEnums.AXISOPTIONS));

            // Populate unit selection box with available units
            YAxis2UnitSelectionBox.Items.Clear();
            foreach (Enum unit in Enum.GetValues(ControlEnums.GetAttribute(currentYAxis2).units.GetType()))
                YAxis2UnitSelectionBox.Items.Add(ControlEnums.GetAttribute(unit).disp);
            YAxis2UnitSelectionBox.SelectedIndex = 0;

            // Update mapper based on selected axis and unit
            if(currentYAxis2 == ControlEnums.AXISOPTIONS.TIME)
                CalculateTimeUnitConversion(series2Mapper, (ControlEnums.TIMEUNITS)currentYAxis2Unit, false);
            else if(currentYAxis2 == ControlEnums.AXISOPTIONS.VOLTAGE)
                CalculateVoltageUnitConversion(series2Mapper, (ControlEnums.VOLTAGEUNITS)currentYAxis2Unit, false);
            else CalculateBaseUnitConversion(series2Mapper, currentYAxis2, (ControlEnums.BASEUNITS)currentYAxis2Unit, false);

            if (currentYAxis2 == ControlEnums.AXISOPTIONS.ACCELERATION && Series2EnabledCheckbox.Checked) {
                Chart.Series.Add(setLine3);
            }
            else if (Chart.Series.Contains(setLine3))
                Chart.Series.Remove(setLine3);
            WipeGraph();
        }

        // Called when the x-axis unit selection changes. Updates the plotting mapper also
        private void OnXAxisUnitSelectionChanged(object sender, EventArgs e) {
            currentXAxisUnit = FindSelectedTextInEnum(XAxisUnitSelectionBox.Text, ControlEnums.GetAttribute(currentXAxis).units.GetType());

            // Update mapper based on selected unit
            if (currentXAxis == ControlEnums.AXISOPTIONS.TIME)
                CalculateTimeUnitConversion(series1Mapper, (ControlEnums.TIMEUNITS)currentXAxisUnit, true);
            else if (currentXAxis == ControlEnums.AXISOPTIONS.VOLTAGE)
                CalculateVoltageUnitConversion(series1Mapper, (ControlEnums.VOLTAGEUNITS)currentXAxisUnit, true);
            else CalculateBaseUnitConversion(series1Mapper, currentXAxis, (ControlEnums.BASEUNITS)currentXAxisUnit, true);
            WipeGraph();
        }

        // Called when the y-axis unit selection changes. Updates the plotting mapper also
        private void OnYAxis1UnitSelectionChanged(object sender, EventArgs e) {
            currentYAxis1Unit = FindSelectedTextInEnum(YAxis1UnitSelectionBox.Text, ControlEnums.GetAttribute(currentYAxis1).units.GetType());

            // Update mapper based on selected unit
            if (currentYAxis1 == ControlEnums.AXISOPTIONS.TIME)
                CalculateTimeUnitConversion(series1Mapper, (ControlEnums.TIMEUNITS)currentYAxis1Unit, false);
            else if (currentYAxis1 == ControlEnums.AXISOPTIONS.VOLTAGE)
                CalculateVoltageUnitConversion(series1Mapper, (ControlEnums.VOLTAGEUNITS)currentYAxis1Unit, false);
            else CalculateBaseUnitConversion(series1Mapper, currentYAxis1, (ControlEnums.BASEUNITS)currentYAxis1Unit, false);
            WipeGraph();
        }

        // Called when the y-axis 2 unit selection changes. Updates the plotting mapper also
        private void OnYAxis2UnitSelectionChanged(object sender, EventArgs e) {
            currentYAxis2Unit = FindSelectedTextInEnum(YAxis2UnitSelectionBox.Text, ControlEnums.GetAttribute(currentYAxis2).units.GetType());

            // Update mapper based on selected unit
            if (currentYAxis2 == ControlEnums.AXISOPTIONS.TIME)
                CalculateTimeUnitConversion(series2Mapper, (ControlEnums.TIMEUNITS)currentYAxis2Unit, false);
            else if (currentYAxis2 == ControlEnums.AXISOPTIONS.VOLTAGE)
                CalculateVoltageUnitConversion(series2Mapper, (ControlEnums.VOLTAGEUNITS)currentYAxis2Unit, false);
            else CalculateBaseUnitConversion(series2Mapper, currentYAxis2, (ControlEnums.BASEUNITS)currentYAxis2Unit, false);
            WipeGraph();
        }

        private void OnDataPointsUpDownChanged(object sender, EventArgs e) {
            GraphPeriodTextBox.Text = (double)(DataPointsUpDown.Value * (MainInterface.instance.ProgramLoopTimer.Interval / 1000.0m)) + " s";
            numDataPoints = (int)DataPointsUpDown.Value;
            WipeGraph();
        }

        private void OnSeries1CheckedChanged(object sender, EventArgs e) {
            if(!Series1EnabledCheckbox.Checked) {
                Chart.Series.Remove(series1);
                Chart.Series.Remove(setLine1);
                if (Chart.Series.Contains(setLine3) && currentYAxis1 == ControlEnums.AXISOPTIONS.ACCELERATION)
                    Chart.Series.Remove(setLine3);
            }
            else {
                Chart.Series.Add(series1);
                Chart.Series.Add(setLine1);
                if (currentYAxis1 == ControlEnums.AXISOPTIONS.ACCELERATION)
                    Chart.Series.Add(setLine3);
            }
            WipeGraph();
        }

        private void OnSeries2CheckedChanged(object sender, EventArgs e) {
            if (!Series2EnabledCheckbox.Checked) {
                Chart.Series.Remove(series2);
                Chart.Series.Remove(setLine2);
                if (Chart.Series.Contains(setLine3) && currentYAxis2 == ControlEnums.AXISOPTIONS.ACCELERATION)
                    Chart.Series.Remove(setLine3);
            }
            else {
                Chart.Series.Add(series2);
                Chart.Series.Add(setLine2);
                if (currentYAxis2 == ControlEnums.AXISOPTIONS.ACCELERATION)
                    Chart.Series.Add(setLine3);
            }
            WipeGraph();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e) {
            MainInterface.graphingOpen = false;
        }
        #endregion

        #region Unit Conversion Methods
        public void CalculateTimeUnitConversion(CartesianMapper<GraphingEntry> mapper, ControlEnums.TIMEUNITS unit, bool xAxis) {
            if (xAxis)
                mapper.X(entry => entry.uptime * GetTimeUnitConversionFactor(unit));
            else mapper.Y(entry => entry.uptime * GetTimeUnitConversionFactor(unit));
        }

        public void CalculateVoltageUnitConversion(CartesianMapper<GraphingEntry> mapper, ControlEnums.VOLTAGEUNITS unit, bool xAxis) {
            if (xAxis)
                mapper.X(entry => entry.voltage * GetVoltageUnitConversionFactor(unit));
            else mapper.Y(entry => entry.voltage * GetVoltageUnitConversionFactor(unit));
        }

        public void CalculateBaseUnitConversion(CartesianMapper<GraphingEntry> mapper, ControlEnums.AXISOPTIONS axis, ControlEnums.BASEUNITS unit, bool xAxis) {
            if (axis == ControlEnums.AXISOPTIONS.POSITION) {
                if (xAxis)
                    mapper.X(entry => entry.position * GetBaseUnitConversionFactor(axis, unit));
                else mapper.Y(entry => entry.position * GetBaseUnitConversionFactor(axis, unit));
            }
            if (axis == ControlEnums.AXISOPTIONS.VELOCITY) {
                if (xAxis)
                    mapper.X(entry => entry.velocity * GetBaseUnitConversionFactor(axis, unit));
                else mapper.Y(entry => entry.velocity * GetBaseUnitConversionFactor(axis, unit));
            }
            if (axis == ControlEnums.AXISOPTIONS.ACCELERATION) {
                if (xAxis)
                    mapper.X(entry => entry.acceleration * GetBaseUnitConversionFactor(axis, unit));
                else mapper.Y(entry => entry.acceleration * GetBaseUnitConversionFactor(axis, unit));
            }
        }

        public double GetBaseUnitConversionFactor(ControlEnums.AXISOPTIONS axis, ControlEnums.BASEUNITS unit) {
            if (unit == ControlEnums.BASEUNITS.DEG)
                return 360.0 / 2000.0;
            if (unit == ControlEnums.BASEUNITS.RAD)
                return 2.0 * Math.PI / 2000.0;
            if (unit == ControlEnums.BASEUNITS.REVS) {
                if (axis == ControlEnums.AXISOPTIONS.POSITION)
                    return 1.0 / 2000.0;
                else return 60.0 / 2000.0;
            }
            return 1.0;
        }

        public double GetTimeUnitConversionFactor(ControlEnums.TIMEUNITS unit) {
            if (unit == ControlEnums.TIMEUNITS.SECONDS)
                return 1.0 / 1000.0;
            return 1.0;
        }

        public double GetVoltageUnitConversionFactor(ControlEnums.VOLTAGEUNITS unit) {
            if (unit == ControlEnums.VOLTAGEUNITS.MILLIS)
                return 1000.0;
            return 1.0;
        }

        public void WipeGraph() {
            series1Values.Clear();
            series2Values.Clear();
            setLine1Values.Clear();
            setLine2Values.Clear();
            setLine3Values.Clear();
        }

        private Enum FindSelectedTextInEnum(string text, Type enumType) {
            foreach (Enum e in Enum.GetValues(enumType)) {
                if (text == ControlEnums.GetAttribute(e).disp) {
                    return e;
                }
            }
            return null;
        }
        #endregion
    }
}
