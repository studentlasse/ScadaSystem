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
        private string controlSystemVerification;
        private string controlSystemVerificationStatus;

        // Automatic
        private float automatic;
        private string automaticStatus;

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
        public string TagControlSystemVerification { get; }
        public string ControlSystemVerification { get { return controlSystemVerification; } }
        public string ControlSystemVerificationStatus { get { return controlSystemVerificationStatus; } }

        // Automatic
        public string TagAutomatic { get; }
        public float Automatic { get { return automatic; } }
        public string AutomaticStatus { get { return automaticStatus; } }

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
            TagControlSystemVerification = ConfigurationManager.AppSettings["tagControlSystemOnlineVerification"];
            TagAutomatic = ConfigurationManager.AppSettings["tagAutomatic"];


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
            processValueStatus = Status(value);

            // Simulated process value
            value = client.ReadNode(TagSimProcessValue);
            simProcessValue = (float) Convert.ToDouble(value.ToString());
            simProcessValueStatus = Status(value);

            // Setpoint
            value = client.ReadNode(TagSetpoint);
            setpoint = (float)Convert.ToDouble(value.ToString());
            setpointStatus = Status(value);

            // Control value
            value = client.ReadNode(TagControlValue);
            controlValue = (float)Convert.ToDouble(value.ToString());
            controlValueStatus = Status(value);

            // Control system online verification
            value = client.ReadNode(TagControlSystemVerification);
            controlSystemVerification = value.ToString();
            controlSystemVerificationStatus = Status(value);

            // Automatic
            value = client.ReadNode(TagAutomatic);
            automatic = (float)Convert.ToDouble(value.ToString());
            automaticStatus = Status(value);
        }

        public void Close()
        {
            if (client != null)
                this.client.Disconnect();
        }

        private string Status(OpcValue value)
        {
            if (value.Status.IsGood)
                return "Good";
            else if (value.Status.IsBad)
                return "Bad";
            else if (value.Status.IsUncertain)
                return "Undertain";
            else if (value.Status.IsOverflow)
                return "Overflow";
            else
                return "Status unknown";
        }
    }
}
