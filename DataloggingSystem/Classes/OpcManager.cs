using Opc.UaFx.Client;
using Opc.UaFx;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggingSystem.Classes
{
    class OpcManager
    {
        private OpcClient client;

        // Process value
        private float processValue;
        private string processValueStatus;

        // Simulated process value
        private float simProcessValue;
        private string simProcessValueStatus;

        // Setpoint
        private float setpoint;
        private string setpointStatus;

        // Control value
        private float controlValue;
        private string controlValueStatus;

        // Random number
        private float connectedRandomNumber;
        private string connectedRandomNumberStatus;

        // I/O error
        private float ioError;
        private string ioErrorStatus;

        // Process value
        public string TagProcessValue { get; }
        public float ProcessValue { get { return processValue; } }
        public string ProcessValueStatus { get { return processValueStatus; } }

        // Simulated process value
        public string TagSimProcessValue { get; }
        public float SimProcessValue { get { return simProcessValue; } }
        public string SimProcessValueStatus { get { return simProcessValueStatus; } }

        // Setpoint
        public string TagSetpoint { get; }
        public float Setpoint { get { return setpoint; } }
        public string SetpointStatus { get { return setpointStatus; } }

        // Control value
        public string TagControlValue { get; }
        public float ControlValue { get { return controlValue; } }
        public string ControlValueStatus { get { return controlValueStatus; } }

        // Connnected random number
        public string TagConnectedRandomNumber { get; }
        public float ConnectedRandomNumber { get { return connectedRandomNumber; } }
        public string ConnectedRandomNumberStatus { get { return connectedRandomNumberStatus; } }

        // I/O error
        public string TagIoError { get; }
        public float IoError { get { return ioError; } }
        public string IoErrorStatus { get { return ioErrorStatus; } }

        // OPC client
        public string OpcUrl { get; }



        public OpcManager()
        {
            // Fetch url string
            OpcUrl = ConfigurationManager.AppSettings["opcUrl"];

            // Get tag daga
            TagProcessValue = ConfigurationManager.AppSettings["tagRealProcessValue"];
            TagSimProcessValue = ConfigurationManager.AppSettings["tagSimProcessValue"];
            TagSetpoint = ConfigurationManager.AppSettings["tagSetpoint"];
            TagControlValue = ConfigurationManager.AppSettings["tagControlValue"];
            TagConnectedRandomNumber = ConfigurationManager.AppSettings["tagConnectedRandomNumbers"];
            TagIoError = ConfigurationManager.AppSettings["tagIOError"];

            // Create OpcClient object
            this.client = new OpcClient(OpcUrl);
        }
        public void Start()
        {
            if (client != null)
                this.client.Connect();
        }

        public void GetData()
        {
            // Process value
            var value = client.ReadNode(TagProcessValue);
            processValue = (float) Convert.ToDouble(value.ToString());
            processValueStatus = value.Status.ToString();

            // Simulated process value
            value = client.ReadNode(TagSimProcessValue);
            simProcessValue = (float) Convert.ToDouble(value.ToString());
            simProcessValueStatus = value.Status.ToString();

            // Setpoint
            value = client.ReadNode(TagSetpoint);
            setpoint = (float)Convert.ToDouble(value.ToString());
            setpointStatus = value.Status.ToString();

            // Control value
            value = client.ReadNode(TagControlValue);
            controlValue = (float)Convert.ToDouble(value.ToString());
            controlValueStatus = value.Status.ToString();

            // Connnected random number
            value = client.ReadNode(TagConnectedRandomNumber);
            connectedRandomNumber = (float)Convert.ToDouble(value.ToString());
            connectedRandomNumberStatus = value.Status.ToString();

            // I/O error
            value = client.ReadNode(TagIoError);
            ioError = (float)Convert.ToDouble(value.ToString());
            ioErrorStatus = value.Status.ToString();
        }

        public void Close()
        {
            if (client != null)
                this.client.Disconnect();
        }
    }
}
