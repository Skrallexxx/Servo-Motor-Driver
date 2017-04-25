using System.Windows.Forms;
using System;
using System.Reflection;

namespace ServoMotorDriver {
    public class ControlEnums {
        // Operation mode enums, defines the possible motor control modes
        public enum MODE {
            [Properties("Freespin")]
            FREESPIN,
            [Properties("Binary Control")]
            BINARY,
            [Properties("Voltage Control")]
            MANUAL_SPEED,
            [Properties("Position Control")]
            POSITIONAL,
            [Properties("Dead-Band Testing")]
            DEAD_BAND_TEST
        }

        public enum DATAMODE {
            [Properties("Decoder Output")]
            DECODER,
            [Properties("Test Data")]
            TEST,
            [Properties("Test Data (with Random)")]
            TESTRAND,
            [Properties("Manual Input")]
            MANUAL
        }

        public enum TIMEUNITS {
            [Properties("Seconds")]
            SECONDS,
            [Properties("Milliseconds")]
            MILLIS
        }

        public enum VOLTAGEUNITS {
            [Properties("Volts")]
            VOLTS,
            [Properties("Millivolts")]
            MILLIS
        }

        public enum BINARYUNITS {
            [Properties("Default")]
            DEFAULT
        }

        public enum POSITIONUNITS {
            [Properties("Counts")]
            COUNTS,
            [Properties("Degrees")]
            DEG,
            [Properties("Radians")]
            RAD,
            [Properties("Revs")]
            REVS
        }

        public enum VELOCITYUNITS {
            [Properties("Counts/s")]
            COUNTS,
            [Properties("Degrees/s")]
            DEG,
            [Properties("Radians/s")]
            RAD,
            [Properties("RPM")]
            RPM
        }

        public enum ACCELERATIONUNITS {
            [Properties("Counts/s²")]
            COUNTS,
            [Properties("Degrees/s²")]
            DEG,
            [Properties("Radians/s²")]
            RAD,
            [Properties("RPM/s")]
            RPM
        }

        public enum AXISOPTIONS {
            [Properties("Time", typeof(TIMEUNITS))]
            TIME,
            [Properties("Voltage", typeof(VOLTAGEUNITS))]
            VOLTAGE,
            [Properties("Binary", typeof(BINARYUNITS))]
            BINARY,
            [Properties("Position", typeof(POSITIONUNITS))]
            POSITION,
            [Properties("Velocity", typeof(VELOCITYUNITS))]
            VELOCITY,
            [Properties("Acceleration", typeof(ACCELERATIONUNITS))]
            ACCELERATION
        }

        // Affix a property attribute to enums to allow extended information about the enum
        public class PropertiesAttribute : Attribute {
            public string disp;
            public Enum units;
            public PropertiesAttribute(string displayString) {
                disp = displayString;
            }

            public PropertiesAttribute(string displayString, Type T) {
                this.disp = displayString;
                if(T == typeof(TIMEUNITS))
                    units = new TIMEUNITS();
                if (T == typeof(VOLTAGEUNITS))
                    units = new VOLTAGEUNITS();
                if (T == typeof(BINARYUNITS))
                    units = new BINARYUNITS();
                if (T == typeof(POSITIONUNITS))
                    units = new POSITIONUNITS();
                if (T == typeof(VELOCITYUNITS))
                    units = new VELOCITYUNITS();
                if (T == typeof(ACCELERATIONUNITS))
                    units = new ACCELERATIONUNITS();
            }

            public PropertiesAttribute() { }
        }

        public static PropertiesAttribute GetAttribute(Enum value) {
            Type type = value.GetType();
            FieldInfo fieldInfo = type.GetField(value.ToString());
            var attributes = (PropertiesAttribute[])fieldInfo.GetCustomAttributes(typeof(PropertiesAttribute), false);
            return attributes.Length > 0 ? attributes[0] : null;
        }
    }
}
