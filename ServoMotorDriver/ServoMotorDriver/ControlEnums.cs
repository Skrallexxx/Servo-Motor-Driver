using System.Windows.Forms;
using System;
using System.Reflection;

namespace ServoMotorDriver {
    public class ControlEnums {
        // Operation mode enums, defines the possible motor control modes
        public enum MODE {
            [Properties("Freespin")]
            FREESPIN,
            [Properties("Speed Control")]
            MANUAL_SPEED,
            [Properties("Speed Control (Dead-Band Compensated)")]
            MANUAL_SPEED_COMP,
            [Properties("Dead-Band Testing")]
            DEAD_BAND_TEST,
            [Properties("Position Control Mode")]
            POSITIONAL
        }

        // Operation direction enums
        public enum DIRECTION {
            [Properties("Clockwise")]
            CLOCKWISE,
            [Properties("Counter-Clockwise")]
            ANTICLOCKWISE
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
