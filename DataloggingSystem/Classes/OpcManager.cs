using Opc.UaFx.Client;
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
        private string connectedRandomNumber;

        private float processValue;
        private float controlValue;
        private string ioError;
        private bool newData;

        public float ProcessValue { get { return processValue; } }
        public float ControlValue { get { return controlValue; } }
        public string IoError { get { return ioError; } }
        public bool NewData { get { return newData; } }

        public string OpcUrl { get; }
        public string TagProcessValue { get; }
        public string TagControlValue { get; }
        public string TagConnectedRandomNumber { get; }
        public string TagIOError { get; }


        public OpcManager()
        {
            // Fetch url string
            OpcUrl = ConfigurationManager.AppSettings["opcUrl"];

            // Get tag daga
            TagProcessValue = ConfigurationManager.AppSettings["tagRealProcessValue"]; // tagRealProcessValue
            TagControlValue = ConfigurationManager.AppSettings["tagControlValue"];
            TagConnectedRandomNumber = ConfigurationManager.AppSettings["tagConnectedRandomNumbers"];
            TagIOError = ConfigurationManager.AppSettings["tagIOError"];

            // Create OpcClient object
            this.client = new OpcClient(OpcUrl);

            connectedRandomNumber = "";
        }
        public void Start()
        {
            if (client != null)
                this.client.Connect();
        }
         
        public void GetData()
        {
            processValue = (float) Convert.ToDouble(client.ReadNode(TagProcessValue).ToString());
            controlValue = (float) Convert.ToDouble(client.ReadNode(TagControlValue).ToString());
            ioError = client.ReadNode(TagIOError).ToString();

            string newRandomNumber = client.ReadNode(TagConnectedRandomNumber).ToString();
            if (connectedRandomNumber.Equals(newRandomNumber))
                newData = true;
            else
                newData = false;

            connectedRandomNumber = newRandomNumber;
        }

        public void Close()
        {
            if (client != null)
                this.client.Disconnect();
        }
    }
}
