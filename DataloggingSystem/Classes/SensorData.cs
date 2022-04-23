using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggingSystem.Classes
{
    class SensorData
    {
        public int SensorDataId{ get; }
        public DateTime TimeStamp { get; }
        public string SensorName { get; }
        public string SensorType { get; }
        public float Measurement { get; }

        public SensorData(int sensorDataId, DateTime timeStamp, string sensorName,
            string sensorType, float measurement)
        {
            this.SensorDataId = sensorDataId;
            this.TimeStamp = timeStamp;
            this.SensorName = sensorName;
            this.SensorType = sensorType;
            this.Measurement = measurement;
        }
    }
}
