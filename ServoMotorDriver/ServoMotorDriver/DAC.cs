using System.Windows.Forms;

namespace ServoMotorDriver
{
    public partial class MainInterface
    {
        // ==================================================================== DAC Class ==================================================================== //

        //DAC characteristics storage class. Stores info about each individual DAC.
        private class DAC
        {
            public decimal gradient = 0m;
            public decimal intercept = 0m;

            public DAC(decimal gradient, decimal intercept)
            {
                this.gradient = gradient;
                this.intercept = intercept;
            }

            public DAC() { }
        }
    }
}
