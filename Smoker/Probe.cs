using System;
using Microsoft.SPOT;

namespace Smoker
{
    public static class Probe
    {
        static public Int32 TempFromRawRead(Double rawread)
        {
            var resistance = (100000 - 100000 * rawread) / rawread;

            var a = 0.00103591448839483;
            var b = 0.00016055742798806;
            var c = 3.03723837011801E-07;

            var kelvin = 1 / (a + b * System.Math.Log(resistance) + c * System.Math.Pow(System.Math.Log(resistance), 3));

            var fahrenheit = (kelvin - 273.15) * 1.8 + 32;

            return (Int32)fahrenheit;
        }
    }
}
