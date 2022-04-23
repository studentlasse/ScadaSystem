using NationalInstruments.DAQmx;
using System;

namespace Simulation.Models
{
    class Daq
    {

        //Test
        Task analogInTask;
        Task analogOutTask;
        AIChannel analogInChannel;
        AOChannel analogOutChannel;
        public bool IoDeviceOk { get; set; }

        public Daq()
        {
            analogInTask = new Task();
            analogOutTask = new Task();


            try
            {
                analogInChannel = analogInTask.AIChannels.CreateVoltageChannel(
                    "dev1/ai0",
                    "AnalogInChannel",
                    AITerminalConfiguration.Differential,
                    0,
                    5,
                    AIVoltageUnits.Volts
                    );

                analogOutChannel = analogOutTask.AOChannels.CreateVoltageChannel(
                    "dev1/ao0",
                        "AnalogOutChannel",
                        0,
                        5,
                        AOVoltageUnits.Volts
                    );
                IoDeviceOk = true;
            }
            catch
            {
                IoDeviceOk = false;
            }
            
        }



        public double ReadData()
        {
            double analogDataIn = -1;
            try
            {
                AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);
                analogDataIn = reader.ReadSingleSample();
            }
            catch
            {
                analogDataIn = -1;
            }
            return analogDataIn;
        }

        public Boolean WriteData(double analogDataOut)
        {
            bool writeOk = false;
            try
            {
                AnalogSingleChannelWriter writer = new AnalogSingleChannelWriter(analogOutTask.Stream);
                writer.WriteSingleSample(true, analogDataOut);
                writeOk = true;
            }
            catch
            {

            }

            return writeOk;
        }
    }
}
