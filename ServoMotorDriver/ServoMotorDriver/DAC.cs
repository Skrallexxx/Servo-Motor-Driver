using System.Windows.Forms;

namespace ServoMotorDriver
{
    public partial class MainInterface : Form
    {
        // ==================================================================== DAC Class ==================================================================== //

        //DAC characteristics storage class. Stores info about each individual DAC.
        private class DAC
        {
            public decimal gradient = 0m;
            public decimal intercept = 0m;
            public decimal rampFirstOrder = 0m;
            public decimal rampSecondOrder = 0m;
            public decimal rampIntercept = 0m;
            public decimal dutyToBinaryGradient = 0m;
            public decimal dutyToBinaryIntercept = 0m;

            public DAC(decimal gradient, decimal intercept, decimal rampSecondOrder, decimal rampFirstOrder, decimal rampIntercept, decimal dutyToBinaryGradient, decimal dutyToBinaryIntercept)
            {
                this.gradient = gradient;
                this.intercept = intercept;
                this.rampSecondOrder = rampSecondOrder;
                this.rampFirstOrder = rampFirstOrder;
                this.rampIntercept = rampIntercept;
                this.dutyToBinaryGradient = dutyToBinaryGradient;
                this.dutyToBinaryIntercept = dutyToBinaryIntercept;
            }

            public DAC() { }
        }
    }
}
