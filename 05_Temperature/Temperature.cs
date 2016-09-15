namespace _05_Temperature
{
    public enum Unit
    {
        Celcius,
        Fahrenheit
    }
    public class Temperature
    {
        public Temperature()
        {

        }

        public Temperature(Unit u, double i)
        {
            if (u == Unit.Celcius)
                Celcius = i;
            else
                Fahrenheit = i;
        }

        public double Fahrenheit;
        public double Celcius;

        public static double FahrenheitToCelcius(double OrigFahren)
        {
            return (OrigFahren - 32) * 5 / 9;
        }

        public static double CelciusToFahrenheit(double OrigCelc)
        {
            return OrigCelc * 9 / 5 +32;
        }

        
        
    }
}

