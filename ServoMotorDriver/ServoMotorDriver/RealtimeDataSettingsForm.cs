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
        public static int velocitySamples = 500, defaultVelocitySamples = 500;
        public static int velocityPeriod = 1, defaultVelocityPeriod = 1;
        public static int accelerationSamples = 500, defaultAccelerationSamples = 500;
        public static int accelerationPeriod = 1, defaultAccelerationPeriod = 1;

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
