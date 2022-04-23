using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggingSystem.Classes
{
    class StatisticsData
    {
        public float AverageValue { get; }
        public float MinValue { get; }
        public float MaxValue { get; }

        public StatisticsData(float averageValue, float minValue, float maxValue)
        {
            this.AverageValue = averageValue;
            this.MinValue = minValue;
            this.MaxValue = maxValue;
        }
    }
}
