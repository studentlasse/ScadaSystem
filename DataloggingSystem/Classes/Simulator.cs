using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggingSystem.Classes
{
    class Simulator
    {
        private float lowerLimit;
        private float upperLimit;
        private float alpha;

        public float LowerLimit { 
            get { return lowerLimit; }
            set { lowerLimit = value < 0 ? -value : value; }
        }
        public float UpperLimit 
        {
            get { return upperLimit; }
            set { upperLimit = value < 0 ? -value : value; }
        }
        public float Alpha {
            get { return alpha; }
            set { alpha = value < 0.0f  || value > 1.0f ? 0.5f : value; }
        }
        public bool Filtering { get; set; }

        private Random random;

        private float previousValue;

        public Simulator(float lowerLimit, float upperLimit, bool filtering = false, float alpha = 0.2f)
        {
            this.LowerLimit = lowerLimit;
            this.UpperLimit = upperLimit;
            this.Filtering = filtering;
            this.Alpha = alpha;

            random = new Random();

            previousValue = LowerLimit;
        }

        public float SimulateData()
        {
            float newValue = lowerLimit + (upperLimit - lowerLimit) * (float) random.NextDouble();

            if (Filtering)
            {

                if (lowerLimit > upperLimit)
                    throw new Exception("Lower limit cannot exceed upper limit in simulator class");

                // Running simple lowpass filter
                float filteredValue = alpha * newValue + (1 - Alpha) * previousValue;
                previousValue = filteredValue;

                return filteredValue;
            }
            else
            {
                previousValue = newValue;

                return newValue;
            }

        }
    }
}
