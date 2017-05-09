using System.Windows.Forms;
using System;
using System.Reflection;

namespace ServoMotorDriver {
    public class ControlEnums {
        public enum DATAMODE {
            [Properties("Decoder Output")]
            DECODER,
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

        public enum BASEUNITS {
            [Properties("Counts")]
            COUNTS,
            [Properties("Degrees")]
            DEG,
            [Properties("Radians")]
            RAD,
            [Properties("Revs")]
            REVS
        }

        public enum AXISOPTIONS {
            [Properties("Time", typeof(TIMEUNITS))]
            TIME,
            [Properties("Voltage", typeof(VOLTAGEUNITS))]
            VOLTAGE,
            [Properties("Binary", typeof(BINARYUNITS))]
            BINARY,
            [Properties("Position", typeof(BASEUNITS))]
            POSITION,
            [Properties("Velocity", typeof(BASEUNITS))]
            VELOCITY,
            [Properties("Acceleration", typeof(BASEUNITS))]
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
                if (T == typeof(BASEUNITS))
                    units = new BASEUNITS();
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
