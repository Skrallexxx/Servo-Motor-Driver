using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServoMotorDriver {
    public partial class TestDataSettingsForm : Form {
        public static int interval = 10, defaultInterval = 10;
        public static int increment = 20, defaultIncrement = 20;
        public static int randMinIncrement = -20, defaultRandMinIncrement = -20;
        public static int randMaxIncrement = 50, defaultRandMaxIncrement = 50;

        public TestDataSettingsForm() {
            InitializeComponent();
            MainInterface.testDataSettingsOpen = true;
            IntervalUpDown.Value = interval;
            IncrementUpDown.Value = increment;
            MinRandomIncrementUpDown.Value = randMinIncrement;
            MaxRandomIncrementUpDown.Value = randMaxIncrement;

            RPMTextBox.Text = Math.Round((60.0 * 1000.0 * increment / (2000.0 * interval)), 2).ToString();
        }

        #region Interface Helper Methods
        // Updates the increment interval
        private void OnIncrementIntervalChanged(object sender, EventArgs e) {
            interval = (int)IntervalUpDown.Value;
            RPMTextBox.Text = Math.Round((60.0 * 1000.0 * increment / (2000.0 * interval)), 2).ToString();
        }

        // Updates the increment value
        private void OnIncrementChanged(object sender, EventArgs e) {
            increment = (int)IncrementUpDown.Value;
            RPMTextBox.Text = Math.Round((60.0 * 1000.0 * increment / (2000.0 * interval)), 2).ToString();
        }

        // Updates the minimum random increment value
        private void OnMinRandChanged(object sender, EventArgs e) {
            randMinIncrement = (int)MinRandomIncrementUpDown.Value;
        }

        // Updates the maximum random increment value
        private void OnMaxRandChanged(object sender, EventArgs e) {
            randMaxIncrement = (int)MaxRandomIncrementUpDown.Value;
        }

        // Resets the values to default when clicked
        private void OnResetDefaultButtonClicked(object sender, EventArgs e) {
            IntervalUpDown.Value = defaultInterval;
            IncrementUpDown.Value = defaultIncrement;
            MinRandomIncrementUpDown.Value = defaultRandMinIncrement;
            MaxRandomIncrementUpDown.Value = defaultRandMaxIncrement;
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e) {
            MainInterface.testDataSettingsOpen = false;
        }
        #endregion
    }
}