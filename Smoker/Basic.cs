using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace Smoker
{
    class Basic
    {
        public void Run()
        {
            AnalogInput probe = new AnalogInput(Cpu.AnalogChannel.ANALOG_4);
            Boolean plateState = false;
            OutputPort HotPlate = new OutputPort(Pins.GPIO_PIN_D0, plateState);
            OutputPort LED = new OutputPort(Pins.ONBOARD_LED, plateState);

            while (true)
            {
                plateState = probe.Read() <= .95;
                HotPlate.Write(plateState);
                LED.Write(plateState);
                Debug.Print(probe.ReadRaw().ToString() + "\t" + probe.Read().ToString() + "\t" + plateState);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
