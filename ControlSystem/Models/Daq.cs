using NationalInstruments.DAQmx;
using System;

namespace Simulation.Models
{
    class Daq
    {
        Task analogInTask;
        Task analogOutTask;
        AIChannel analogInChannel;
        AOChannel analogOutChannel;

        public Daq()
        {
            analogInTask = new Task();
            analogOutTask = new Task();

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
        }



        public double ReadData()
        {
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);

            double analogDataIn = reader.ReadSingleSample();

            return analogDataIn;
        }

        public void WriteData(double analogDataOut)
        {
            AnalogSingleChannelWriter writer = new AnalogSingleChannelWriter(analogOutTask.Stream);

            writer.WriteSingleSample(true, analogDataOut);
        }
    }
}
