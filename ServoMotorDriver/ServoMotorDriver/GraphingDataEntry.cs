using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServoMotorDriver {
    public class GraphingEntry {
        public double uptime = 0.0;
        public double voltage = 0.0;
        public int binary = 0;
        public Int64 position = 0;
        public Int32 rotationPosition = 0;
        public double velocity = 0.0;
        public double acceleration = 0.0;

        public GraphingEntry(double uptime) {
            this.uptime = uptime;
        }

        public GraphingEntry setVoltage(double voltage) {
            this.voltage = voltage;
            return this;
        }

        public GraphingEntry setBinary(int binary) {
            this.binary = binary;
            return this;
        }

        public GraphingEntry setPosition(Int64 position) {
            this.position = position;
            return this;
        }

        public GraphingEntry setRotationPosition(Int32 rotationPosition) {
            this.rotationPosition = rotationPosition;
            return this;
        }

        public GraphingEntry setVelocity(double velocity) {
            this.velocity = velocity;
            return this;
        }

        public GraphingEntry setAcceleration(double acceleration) {
            this.acceleration = acceleration;
            return this;
        }
    }

    public class GraphingLine {
        public double uptime = 0.0;
        public double y = 0.0;

        public GraphingLine(double time, double y) {
            this.uptime = time;
            this.y = y;
        }
    }
}
