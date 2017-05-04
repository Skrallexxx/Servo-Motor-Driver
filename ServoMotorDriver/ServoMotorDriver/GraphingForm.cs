using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using LiveCharts.Geared;
using System;
using System.Windows.Forms;

namespace ServoMotorDriver {
    public partial class GraphingForm : Form {
        public GearedValues<GraphingDataEntry> chartValues = new GearedValues<GraphingDataEntry>();
        public GearedValues<GraphingLine> chartLine = new GearedValues<GraphingLine>();
        CartesianMapper<GraphingDataEntry> mapper = Mappers.Xy<GraphingDataEntry>();
        CartesianMapper<GraphingLine> lineMapper = Mappers.Xy<GraphingLine>();

        public static double positionLineY = 0.0;
        public static double velocityLineY = 0.0;
        public static double accelerationLineY = 0.0;

        public ControlEnums.AXISOPTIONS currentXAxis = ControlEnums.AXISOPTIONS.TIME;
        public ControlEnums.AXISOPTIONS currentYAxis = ControlEnums.AXISOPTIONS.VELOCITY;
        public Enum currentXAxisUnit = ControlEnums.TIMEUNITS.SECONDS;
        public Enum currentYAxisUnit = ControlEnums.POSITIONUNITS.COUNTS;

        public GraphingForm() {
            InitializeComponent();
            MainInterface.graphingOpen = true;

            // Populate the axes selection boxes
            foreach (ControlEnums.AXISOPTIONS axis in Enum.GetValues(typeof(ControlEnums.AXISOPTIONS))) {
                XAxisSelectionBox.Items.Add(ControlEnums.GetAttribute(axis).disp);
                YAxisSelectionBox.Items.Add(ControlEnums.GetAttribute(axis).disp);
            }
            XAxisSelectionBox.SelectedIndex = 0;
            YAxisSelectionBox.SelectedIndex = 4;

            mapper = Mappers.Xy<GraphingDataEntry>().X(entry => entry.uptime / 1000.0).Y(entry => entry.velocity);
            Charting.For<GraphingDataEntry>(mapper);

            lineMapper = Mappers.Xy<GraphingLine>().X(line => line.uptime / 1000.0).Y(line => line.y);
            Charting.For<GraphingLine>(lineMapper);

            Chart.Series = new SeriesCollection {
                new LineSeries {
                    Values = chartValues, PointGeometrySize = 2, StrokeThickness = 2 },
                new LineSeries {
                    Values = chartLine, PointGeometrySize = 2, StrokeThickness = 2, Stroke = System.Windows.Media.Brushes.Green, Fill = System.Windows.Media.Brushes.Transparent }
            };

            Chart.AxisX.Add(new Axis {
                DisableAnimations = true});
            Chart.DisableAnimations = true;
            Chart.Hoverable = false;
            Chart.DataTooltip = null;
            chartValues.WithQuality(Quality.Highest);
            chartLine.WithQuality(Quality.Highest);
        }

        public void AddGraphingEntry(GraphingDataEntry entry) {
            chartValues.Add(entry);
            if (chartValues.Count > 120) chartValues.RemoveAt(0);

            double yVal = 0.0;
            if (currentYAxis == ControlEnums.AXISOPTIONS.POSITION)
                yVal = positionLineY;
            if (currentYAxis == ControlEnums.AXISOPTIONS.VELOCITY)
                yVal = velocityLineY;
            if (currentYAxis == ControlEnums.AXISOPTIONS.ACCELERATION)
                yVal = accelerationLineY;

            chartLine.Add(new GraphingLine(entry.uptime, yVal));
            if (chartLine.Count > 120) chartLine.RemoveAt(0);
        }

        #region Interface Helper Methods
        private void OnGraphSettingsMenuClicked(object sender, EventArgs e) {

        }

        // Called when the x-axis selection is changed. Updates the plotting mapper also
        private void OnXAxisSelectionChanged(object sender, EventArgs e) {
            foreach(ControlEnums.AXISOPTIONS axis in Enum.GetValues(typeof(ControlEnums.AXISOPTIONS))) {
                if(XAxisSelectionBox.Text == ControlEnums.GetAttribute(axis).disp) {
                    currentXAxis = axis;
                    break;
                }
            }

            XAxisUnitSelectionBox.Items.Clear();
            foreach (Enum unit in Enum.GetValues(ControlEnums.GetAttribute(currentXAxis).units.GetType()))
                XAxisUnitSelectionBox.Items.Add(ControlEnums.GetAttribute(unit).disp);
            XAxisUnitSelectionBox.SelectedIndex = 0;

            // Change the x-axis value of the mapper depending on the axis selection
            if(currentXAxis == ControlEnums.AXISOPTIONS.TIME)
                mapper.X(entry => entry.uptime);
            if (currentXAxis == ControlEnums.AXISOPTIONS.BINARY)
                mapper.X(entry => entry.binary);
            if (currentXAxis == ControlEnums.AXISOPTIONS.VOLTAGE)
                mapper.X(entry => entry.voltage);
            if (currentXAxis == ControlEnums.AXISOPTIONS.POSITION)
                mapper.X(entry => entry.position);
            if (currentXAxis == ControlEnums.AXISOPTIONS.VELOCITY)
                mapper.X(entry => entry.velocity);
            if (currentXAxis == ControlEnums.AXISOPTIONS.ACCELERATION)
                mapper.X(entry => entry.acceleration);
            chartValues.Clear();
            chartLine.Clear();
        }

        // Called when the y-axis selection changes. Updates the plotting mapper also
        private void OnYAxisSelectionChanged(object sender, EventArgs e) {
            foreach (ControlEnums.AXISOPTIONS axis in Enum.GetValues(typeof(ControlEnums.AXISOPTIONS))) {
                if (YAxisSelectionBox.Text == ControlEnums.GetAttribute(axis).disp) {
                    currentYAxis = axis;
                    break;
                }
            }

            YAxisUnitSelectionBox.Items.Clear();
            foreach (Enum unit in Enum.GetValues(ControlEnums.GetAttribute(currentYAxis).units.GetType()))
                YAxisUnitSelectionBox.Items.Add(ControlEnums.GetAttribute(unit).disp);
            YAxisUnitSelectionBox.SelectedIndex = 0;

            // Change the y-axis value of the mapper depending on the axis selection
            if (currentYAxis == ControlEnums.AXISOPTIONS.TIME)
                mapper.Y(entry => entry.uptime);
            if (currentYAxis == ControlEnums.AXISOPTIONS.BINARY)
                mapper.Y(entry => entry.binary);
            if (currentYAxis == ControlEnums.AXISOPTIONS.VOLTAGE)
                mapper.Y(entry => entry.voltage);
            if (currentYAxis == ControlEnums.AXISOPTIONS.POSITION)
                mapper.Y(entry => entry.position);
            if (currentYAxis == ControlEnums.AXISOPTIONS.VELOCITY)
                mapper.Y(entry => entry.velocity);
            if (currentYAxis == ControlEnums.AXISOPTIONS.ACCELERATION)
                mapper.Y(entry => entry.acceleration);
            chartValues.Clear();
            chartLine.Clear();
        }

        // Called when the x-axis unit selection changes. Updates the plotting mapper also
        private void OnXAxisUnitSelectionChanged(object sender, EventArgs e) {
            foreach(Enum en in Enum.GetValues(ControlEnums.GetAttribute(currentXAxis).units.GetType())) {
                if(XAxisUnitSelectionBox.Text == ControlEnums.GetAttribute(en).disp) {
                    currentXAxisUnit = en;
                    break;
                }
            }

            // Updates the x-axis value of the mapper for different time units
            if(currentXAxis == ControlEnums.AXISOPTIONS.TIME) {
                if (currentXAxisUnit.Equals(ControlEnums.TIMEUNITS.SECONDS))
                    mapper.X(entry => entry.uptime / 1000.0);
                if (currentXAxisUnit.Equals(ControlEnums.TIMEUNITS.MILLIS))
                    mapper.X(entry => entry.uptime);
            }

            // Updates the x-axis value of the mapper for different voltage units
            if(currentXAxis == ControlEnums.AXISOPTIONS.VOLTAGE) {
                if (currentXAxisUnit.Equals(ControlEnums.VOLTAGEUNITS.VOLTS))
                    mapper.X(entry => entry.voltage);
                if (currentXAxisUnit.Equals(ControlEnums.VOLTAGEUNITS.MILLIS))
                    mapper.X(entry => entry.voltage / 1000.0);
            }

            // Updates the x-axis value of the mapper for different position units
            if(currentXAxis == ControlEnums.AXISOPTIONS.POSITION) {
                if (currentXAxisUnit.Equals(ControlEnums.POSITIONUNITS.COUNTS))
                    mapper.X(entry => entry.position);
                if (currentXAxisUnit.Equals(ControlEnums.POSITIONUNITS.DEG))
                    mapper.X(entry => Math.Round(360.0 * entry.rotationPosition / 2000.0, 2));
                if (currentXAxisUnit.Equals(ControlEnums.POSITIONUNITS.RAD))
                    mapper.X(entry => Math.Round(2.0 * entry.rotationPosition / 2000.0, 2));
                if (currentXAxisUnit.Equals(ControlEnums.POSITIONUNITS.REVS))
                    mapper.X(entry => Math.Round(entry.position / 2000.0, 2));
            }

            // Updates the x-axis value of the mapper for different velocity units
            if(currentXAxis == ControlEnums.AXISOPTIONS.VELOCITY) {
                if (currentXAxisUnit.Equals(ControlEnums.VELOCITYUNITS.COUNTS))
                    mapper.X(entry => entry.velocity);
                if (currentXAxisUnit.Equals(ControlEnums.VELOCITYUNITS.DEG))
                    mapper.X(entry => Math.Round(360.0 * entry.velocity / 2000.0, 2));
                if (currentXAxisUnit.Equals(ControlEnums.VELOCITYUNITS.RAD))
                    mapper.X(entry => Math.Round(2.0 * entry.velocity / 2000.0, 2));
                if (currentXAxisUnit.Equals(ControlEnums.VELOCITYUNITS.RPM))
                    mapper.X(entry => Math.Round(entry.velocity * 60.0 / 2000.0, 2));
            }

            // Updates the x-axis value of the mapper for different acceleration units
            if(currentXAxis == ControlEnums.AXISOPTIONS.ACCELERATION) {
                if (currentXAxisUnit.Equals(ControlEnums.ACCELERATIONUNITS.COUNTS))
                    mapper.X(entry => entry.acceleration);
                if (currentXAxisUnit.Equals(ControlEnums.ACCELERATIONUNITS.DEG))
                    mapper.X(entry => Math.Round(360.0 * entry.acceleration / 2000.0, 2));
                if (currentXAxisUnit.Equals(ControlEnums.ACCELERATIONUNITS.RAD))
                    mapper.X(entry => Math.Round(2.0 * entry.acceleration / 2000.0, 2));
                if (currentXAxisUnit.Equals(ControlEnums.ACCELERATIONUNITS.RPM))
                    mapper.X(entry => Math.Round(entry.acceleration * 60.0 / 2000.0, 2));
            }

            chartValues.Clear();
            chartLine.Clear();
        }

        // Called when the y-axis unit selection changes. Updates the plotting mapper also
        private void OnYAxisUnitSelectionChanged(object sender, EventArgs e) {
            foreach (Enum en in Enum.GetValues(ControlEnums.GetAttribute(currentYAxis).units.GetType())) {
                if (YAxisUnitSelectionBox.Text == ControlEnums.GetAttribute(en).disp) {
                    currentYAxisUnit = en;
                    break;
                }
            }

            // Updates the y-axis value of the mapper for different time units
            if (currentYAxis == ControlEnums.AXISOPTIONS.TIME) {
                if (currentYAxisUnit.Equals(ControlEnums.TIMEUNITS.SECONDS))
                    mapper.Y(entry => entry.uptime / 1000.0);
                if (currentYAxisUnit.Equals(ControlEnums.TIMEUNITS.MILLIS))
                    mapper.Y(entry => entry.uptime);
            }

            // Updates the y-axis value of the mapper for different voltage units
            if (currentYAxis == ControlEnums.AXISOPTIONS.VOLTAGE) {
                if (currentYAxisUnit.Equals(ControlEnums.VOLTAGEUNITS.VOLTS))
                    mapper.Y(entry => entry.voltage);
                if (currentYAxisUnit.Equals(ControlEnums.VOLTAGEUNITS.MILLIS))
                    mapper.Y(entry => entry.voltage / 1000.0);
            }

            // Updates the y-axis value of the mapper for different position units
            if (currentYAxis == ControlEnums.AXISOPTIONS.POSITION) {
                if (currentYAxisUnit.Equals(ControlEnums.POSITIONUNITS.COUNTS))
                    mapper.Y(entry => entry.position);
                if (currentYAxisUnit.Equals(ControlEnums.POSITIONUNITS.DEG)) {
                    mapper.Y(entry => Math.Round(360.0 * entry.rotationPosition / 2000.0, 2));
                    lineMapper.Y(line => Math.Round(360.0 * line.y / 2000.0, 2));
                }
                if (currentYAxisUnit.Equals(ControlEnums.POSITIONUNITS.RAD)) {
                    mapper.Y(entry => Math.Round(2.0 * entry.rotationPosition / 2000.0, 2));
                    lineMapper.Y(line => Math.Round(2.0 * line.y / 2000.0, 2));
                }
                if (currentYAxisUnit.Equals(ControlEnums.POSITIONUNITS.REVS)) {
                    mapper.Y(entry => Math.Round(entry.position / 2000.0, 2));
                    lineMapper.Y(line => Math.Round(line.y / 2000.0, 2));
                }
            }

            // Updates the y-axis value of the mapper for different velocity units
            if (currentYAxis == ControlEnums.AXISOPTIONS.VELOCITY) {
                if (currentYAxisUnit.Equals(ControlEnums.VELOCITYUNITS.COUNTS))
                    mapper.Y(entry => entry.velocity);
                if (currentYAxisUnit.Equals(ControlEnums.VELOCITYUNITS.DEG)) {
                    mapper.Y(entry => Math.Round(360.0 * entry.velocity / 2000.0, 2));
                    lineMapper.Y(line => Math.Round(360.0 * line.y / 2000.0, 2));
                }
                if (currentYAxisUnit.Equals(ControlEnums.VELOCITYUNITS.RAD)) {
                    mapper.Y(entry => Math.Round(2.0 * entry.velocity / 2000.0, 2));
                    lineMapper.Y(line => Math.Round(2.0 * line.y / 2000.0, 2));
                }
                if (currentYAxisUnit.Equals(ControlEnums.VELOCITYUNITS.RPM)) {
                    mapper.Y(entry => Math.Round(entry.velocity * 60.0 / 2000.0, 2));
                    lineMapper.Y(line => Math.Round(line.y * 60.0 / 2000.0, 2));
                }
            }

            // Updates the y-axis value of the mapper for different acceleration units
            if (currentYAxis == ControlEnums.AXISOPTIONS.ACCELERATION) {
                if (currentYAxisUnit.Equals(ControlEnums.ACCELERATIONUNITS.COUNTS))
                    mapper.Y(entry => entry.acceleration);
                if (currentYAxisUnit.Equals(ControlEnums.ACCELERATIONUNITS.DEG)) {
                    mapper.Y(entry => Math.Round(360.0 * entry.acceleration / 2000.0, 2));
                    lineMapper.Y(line => Math.Round(360.0 * line.y / 2000.0, 2));
                }
                if (currentYAxisUnit.Equals(ControlEnums.ACCELERATIONUNITS.RAD)) {
                    mapper.Y(entry => Math.Round(2.0 * entry.acceleration / 2000.0, 2));
                    lineMapper.Y(line => Math.Round(2.0 * line.y / 2000.0, 2));
                }
                if (currentYAxisUnit.Equals(ControlEnums.ACCELERATIONUNITS.RPM)) {
                    mapper.Y(entry => Math.Round(entry.acceleration * 60.0 / 2000.0, 2));
                    lineMapper.Y(line => Math.Round(line.y * 60.0 / 2000.0, 2));
                }
            }

            chartValues.Clear();
            chartLine.Clear();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e) {
            MainInterface.graphingOpen = false;
        }
        #endregion
    }
}
