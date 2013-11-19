using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace Smoker
{
    public class Program
    {
        public static void Main()
        {

            Basic controller = new Basic();
            //PID controller = new PID();

            controller.Run();
        }

    }
}
