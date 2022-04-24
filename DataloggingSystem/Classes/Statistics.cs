using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggingSystem.Classes
{
    class Statistics
    {
        private int numberOfMeasurements;

        private float min;
        private float max;
        private float average;
        private float sum;

        public float Min { get { return min; } }
        public float Max { get { return max; } }
        public float Average { get { return average; } }

        public Statistics()
        {
            numberOfMeasurements = 0;
            min = 0;
            max = 0;
            average = 0;
            sum = 0;
        }

        public void Reset()
        {
            numberOfMeasurements = 0;
            min = 0;
            max = 0;
            average = 0;
            sum = 0;
        }

        public void Update(float measurement)
        {
            numberOfMeasurements++;
            sum += measurement;

            average = sum / numberOfMeasurements;

            if (numberOfMeasurements == 1)
            {
                min = measurement;
                max = measurement;
            }

            if (measurement < min)
                min = measurement;
            if (measurement > max)
                max = measurement;
        }
    }
}
