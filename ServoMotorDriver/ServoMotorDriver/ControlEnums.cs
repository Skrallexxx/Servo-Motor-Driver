using System.Windows.Forms;
using System;
using System.Reflection;

namespace ServoMotorDriver {
    public partial class MainInterface {
        private class ControlEnums {
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

            public enum POSITIONUNITS {
                [Properties("Deg")]
                DEG,
                [Properties("Rad")]
                RAD,
                [Properties("Counts")]
                COUNTS,
                [Properties("Revs")]
                REVS
            }

            public enum VELOCITYUNITS {
                [Properties("Deg/s")]
                DEG,
                [Properties("Rad/s")]
                RAD,
                [Properties("Counts/s")]
                COUNTS,
                [Properties("RPM")]
                RPM
            }

            public enum ACCELERATIONUNITS {
                [Properties("Deg/s²")]
                DEG,
                [Properties("Rad/s²")]
                RAD,
                [Properties("Counts/s²")]
                COUNTS,
                [Properties("RPM/s")]
                RPM
            }

            // Affix a property attribute to enums to allow extended information about the enum
            public class PropertiesAttribute : Attribute {
                public string disp;
                public PropertiesAttribute(string displayString) {
                    disp = displayString;
                }

                public PropertiesAttribute() { }

                public string Description {
                    get { return disp; }
                }
            }

            public static PropertiesAttribute GetAttribute(Enum value) {
                Type type = value.GetType();
                FieldInfo fieldInfo = type.GetField(value.ToString());
                var attributes = (PropertiesAttribute[])fieldInfo.GetCustomAttributes(typeof(PropertiesAttribute), false);
                return attributes.Length > 0 ? attributes[0] : null;
            }
        }
    }
}
