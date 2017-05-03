using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace ServoMotorDriver {
    public partial class MainInterface {
        public class Communications {
            // Received inputs and outgoing outputs
            public static byte dacCurrentValue = 0;

            // Communication Variables
            public const byte START = 0x7E, PAD = 0x7D, END = 0x7E;
            public const byte cmdReadDecoder = 0x01, cmdRstDecoder = 0x02, cmdSetDAC = 0x03, cmdReadDAC = 0x04;
            static byte cmdByte = 0, lenByte1 = 0, lenByte2 = 0, checkByte1 = 0, checkByte2 = 0;

            // References
            static SerialPort serial = instance.SerialComPort;

            // Attempts to open the serial port communication on the given com port. Can reopen if already open
            public static void TryOpenSerialCommunication(string portName, bool reOpen = false) {
                // Check if the bluetooth has been connected
                if (serial.PortName == portName && serial.IsOpen) {
                    instance.WriteMessage("Communication is already established on the selected COM port");
                    return;
                }

                serial.PortName = portName;
                if (reOpen || serial.IsOpen)
                    serial.Close();
                if (!serial.IsOpen) {
                    if (portName.Length == 0)
                        return;
                    try {
                        //Try to connect to the bluetooth
                        instance.WriteMessage("Attempting to open communication on " + portName);
                        serial.Open();
                    }
                    catch(System.UnauthorizedAccessException) {
                        //If the bluetooth does not connect return an error
                        instance.WriteError("Failed to open communication on " + portName);
                    }
                    if(serial.IsOpen) instance.WriteMessage("Communication successfully opened on " + portName);
                }
            }

            // Reads the decoder information and returns it as a pair of 32-bit int (time) and 16bit int (decoder value)
            public static KeyValuePair<Int32, Int16> ReadDecoder() {
                SendOutgoingData(cmdReadDecoder, 1, new byte[] { 0 });

                byte[] decoderBytes = Read(cmdReadDecoder);
                if(decoderBytes != null) {
                    if (decoderBytes.Length == 6) {
                        KeyValuePair<Int32, Int16> decoder = new KeyValuePair<Int32, Int16>((decoderBytes[0] << 24) | (decoderBytes[1] << 16) | (decoderBytes[2] << 8) | decoderBytes[3], (Int16)((decoderBytes[4] << 8) | decoderBytes[5]));
                        return decoder;
                    }
                }

                return new KeyValuePair<int, short>(0, 0);
            }

            // Reads the DAC value back to the interface
            public static byte ReadDAC() {
                SendOutgoingData(cmdReadDAC, 1, new byte[] { 0 });

                byte[] dacByte = Read(cmdReadDAC);
                if(dacByte != null) {
                    if(dacByte.Length == 1) {
                        return dacByte[0];
                    }

                }
                return 0;
            }

            // Reads incoming packets from the arduino
            public static byte[] Read(byte CMD) {
                if (!serial.IsOpen) TryOpenSerialCommunication(serial.PortName);

                if (serial.BytesToRead >= 8) {
                    Int16 checkSum = 0;
                    if (serial.ReadByte() != START) return null;
                    cmdByte = (byte)serial.ReadByte();
                    lenByte1 = (byte)serial.ReadByte();

                    byte[] dataBytes = new byte[lenByte1];

                    for (int i = 0; i < lenByte1; i++) {
                        dataBytes[i] = (byte)serial.ReadByte();
                        checkSum += dataBytes[i];
                    }

                    lenByte2 = (byte)serial.ReadByte();
                    checkByte1 = (byte)serial.ReadByte();
                    checkByte2 = (byte)serial.ReadByte();
                    if (serial.ReadByte() != END) return null;
                    if (lenByte1 != lenByte2) return null;

                    checkSum += (byte)(cmdByte + lenByte1 + lenByte2);
                    Int16 receivedCheckSum = (Int16)((checkByte1 << 8) | checkByte2);
                    if (checkSum != receivedCheckSum) {
                        instance.WriteError("Received invalid checksum");
                        return null;
                    }

                    if (cmdByte == CMD) {
                        return dataBytes;
                    }
                    else {
                        instance.WriteError("Received invalid CMD byte " + cmdByte);
                        return null;
                    }
                }
                return null;
            }

            public static void SendOutgoingData(byte CMD, byte LEN, byte[] DATA) {
                if (!serial.IsOpen) TryOpenSerialCommunication(serial.PortName);

                byte[] bytesToWrite = new byte[7 + LEN];
                bytesToWrite[0] = START; bytesToWrite[1] = CMD; bytesToWrite[2] = LEN;

                Int16 checkSum = 0;

                for(int i = 0; i < LEN; i++) {
                    bytesToWrite[3 + i] = DATA[i];
                    checkSum += DATA[i];
                }

                checkSum += (Int16)(CMD + LEN + LEN);
                bytesToWrite[3 + LEN] = LEN; bytesToWrite[4 + LEN] = (byte)(checkSum >> 8); bytesToWrite[5 + LEN] = (byte)(checkSum); bytesToWrite[6 + LEN] = END;
                serial.Write(bytesToWrite, 0, 7 + LEN);
            }

            public static void SendResetCommand() {
                if (serial.BytesToWrite > 0)
                    serial.DiscardOutBuffer();
                SendOutgoingData(cmdRstDecoder, 1, new byte[] { 0 });
            }
        }
    }
}
