using System.IO.Ports;
using System.Threading;

namespace ServoMotorDriver {
    public partial class MainInterface {
        public class Communications {
            // Received inputs and outgoing outputs
            public static int decoderHigh = 0, decoderLow = 0, dacCurrentValue = 0;
            public static byte[] Inputs = new byte[4];
            public static byte[] Outputs = new byte[4];

            // Communication Variables
            public const byte decoderHighPort = 0, decoderLowPort = 1, DACPort = 2, DACCheckPort = 3, decoderRSTPort = 4;
            public const byte START = 255, REQ = 0;

            // Attempts to open the serial port communication on the given com port. Can reopen if already open
            public static void TryOpenSerialCommunication(string portName, bool reOpen = false) {
                // Check if the bluetooth has been connected
                if (instance.SerialComPort.PortName == portName && instance.SerialComPort.IsOpen) {
                    instance.WriteMessage("Communication is already established on the selected COM port");
                    return;
                }
                if (reOpen = true && instance.SerialComPort.IsOpen)
                    instance.SerialComPort.Close();
                if (!instance.SerialComPort.IsOpen) {
                    if (portName.Length == 0)
                        return;
                    instance.SerialComPort.PortName = portName;
                    try {
                        //Try to connect to the bluetooth
                        instance.WriteMessage("Attempting to open communication on " + portName);
                        instance.SerialComPort.Open();
                        instance.WriteMessage("Communication successfully opened on " + portName);
                    }
                    catch {
                        //If the bluetooth does not connect return an error
                        instance.WriteError("Failed to open communication on " + portName);
                    }
                }
            }

            // Reads the incoming data from the arduino
            public static void ReadIncomingData() {
                if (!instance.SerialComPort.IsOpen) return;

                // Send an update request for incoming values
                SendOutgoingData(decoderHighPort, REQ);
                SendOutgoingData(decoderLowPort, REQ);
                SendOutgoingData(DACCheckPort, REQ);

                while (instance.SerialComPort.BytesToRead >= 4) {
                    Inputs[0] = (byte)instance.SerialComPort.ReadByte();
                    if (Inputs[0] != START) return;
                    Inputs[1] = (byte)instance.SerialComPort.ReadByte();
                    Inputs[2] = (byte)instance.SerialComPort.ReadByte();
                    Inputs[3] = (byte)instance.SerialComPort.ReadByte();

                    byte checksum = (byte)(Inputs[0] + Inputs[1] + Inputs[2]);
                    if (Inputs[3] != checksum) {
                        instance.WriteError("Received invalid data packet");
                        return;
                    }

                    if (Inputs[1] == decoderHighPort) {
                        decoderHigh = Inputs[2];
                    }
                    else if (Inputs[1] == decoderLowPort) {
                        decoderLow = Inputs[2];
                    }
                    else if (Inputs[1] == DACCheckPort) {
                        dacCurrentValue = Inputs[2];
                        instance.CurrentBinaryTextBox.Text = dacCurrentValue.ToString();
                        instance.CurrentVoltageTextBox.Text = instance.CalculateVoltageFromBinary(dacCurrentValue).ToString();
                    }
                    else if (Inputs[1] == decoderRSTPort) {
                        if (Inputs[2] == (byte)(1))
                            Interlocked.Add(ref instance.totalPosAtomic, 20000);
                        if (Inputs[2] == (byte)(2))
                            Interlocked.Add(ref instance.totalPosAtomic, -20000);
                    }
                    else instance.WriteError("Received invalid PORT byte " + Inputs[2]);
                }
            }

            // Send the outgoing data to the arduino
            public static void SendOutgoingData(byte PORT, byte DATA) {
                Outputs[0] = START;
                Outputs[1] = PORT;
                Outputs[2] = DATA;
                Outputs[3] = (byte)(START + PORT + DATA);
                if (!instance.SerialComPort.IsOpen) return;
                instance.SerialComPort.Write(Outputs, 0, 4);
            }
        }
    }
}
