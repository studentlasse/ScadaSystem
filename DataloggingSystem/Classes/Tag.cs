using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggingSystem.Classes
{
    public class Tag
    {
        public Tag(float time, float processValue, float simValue, float setpoint, float controlValue, float ioError, float randomNumber)
        {
            this.time = time;
            this.processValue = processValue;
            this.simValue = simValue;
            this.setpoint = setpoint;
            this.controlValue = controlValue;
            this.ioError = ioError;
            this.randomNumber = randomNumber;
        }

        public float time;
        public float processValue;
        public float simValue;
        public float setpoint;
        public float controlValue;
        public float ioError;
        public float randomNumber;
    }
}
