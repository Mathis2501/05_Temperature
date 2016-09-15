using System;

namespace _05_Temperature
{
    internal interface ITemperature
    {
        double Convert(double T);
    }
    internal class TemperatureFactory
    {
        internal static ITemperature Get(Unit E)
        {
            if (E == Unit.Celcius)
            {
                return new Celcius();
            }
            else
            {
                return new Fahrenheit();
            }
        }

    }

    internal class Celcius : ITemperature
    {
        public double Convert(double T)
        {
            return (5 * T - 160) / 9;
        }
    }
    internal class Fahrenheit : ITemperature
    {
        public double Convert(double T)
        {
            return T * 9 / 5 + 32;
        }
    }
}