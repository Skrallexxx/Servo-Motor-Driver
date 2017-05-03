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
    public partial class RealtimeDataSettingsForm : Form {
        public static int velocitySamples = 50, defaultVelocitySamples = 50;
        public static int velocityPeriod = 10, defaultVelocityPeriod = 10;
        public static int accelerationSamples = 50, defaultAccelerationSamples = 50;
        public static int accelerationPeriod = 10, defaultAccelerationPeriod = 10;

        public RealtimeDataSettingsForm() {
            InitializeComponent();
            MainInterface.realtimeDataSettingsOpen = true;

            VelocitySamplesUpDown.Value = velocitySamples;
            VelocityPeriodUpDown.Value = velocityPeriod;
            AccelerationSamplesUpDown.Value = accelerationSamples;
            AccelerationPeriodUpDown.Value = accelerationPeriod;

            VelocityUpdateTimeTextBox.Text = (velocitySamples * velocityPeriod).ToString();
            AccelerationUpdateTimeTextBox.Text = (accelerationSamples * accelerationPeriod).ToString();
        }

        private void OnVelocitySamplesChanged(object sender, EventArgs e) {
            velocitySamples = (int)VelocitySamplesUpDown.Value;
            VelocityUpdateTimeTextBox.Text = (velocitySamples * velocityPeriod).ToString();
        }

        private void OnVelocityPeriodChanged(object sender, EventArgs e) {
            velocityPeriod = (int)VelocityPeriodUpDown.Value;
            VelocityUpdateTimeTextBox.Text = (velocitySamples * velocityPeriod).ToString();
        }

        private void OnVelocityResetButtonClicked(object sender, EventArgs e) {
            VelocitySamplesUpDown.Value = defaultVelocitySamples;
            VelocityPeriodUpDown.Value = defaultVelocityPeriod;
        }

        private void OnAccelerationSamplesChanged(object sender, EventArgs e) {
            accelerationSamples = (int)AccelerationSamplesUpDown.Value;
            AccelerationUpdateTimeTextBox.Text = (accelerationSamples * accelerationPeriod).ToString();
        }

        private void OnAccelerationPeriodChanged(object sender, EventArgs e) {
            accelerationPeriod = (int)AccelerationPeriodUpDown.Value;
            AccelerationUpdateTimeTextBox.Text = (accelerationSamples * accelerationPeriod).ToString();
        }

        private void OnAcclerationResetButtonClicked(object sender, EventArgs e) {
            AccelerationSamplesUpDown.Value = defaultAccelerationSamples;
            AccelerationPeriodUpDown.Value = defaultAccelerationPeriod;
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e) {
            MainInterface.realtimeDataSettingsOpen = false;
        }
    }
}
