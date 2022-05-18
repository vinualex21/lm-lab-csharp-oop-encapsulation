using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        public readonly string Location;
        public double Temperature;
        private const double THRESHOLD_HOT = 30;
        private const double THRESHOLD_COLD = 10;

        public WeatherReporter(string location, double temperature)
        {
            Location = location;
            Temperature = temperature;
        }

        public void PrintFahrenheitWeatherReport()
        {
            var FahrenheitTemp = ConvertCelciusToFahrenheit(Temperature);
            Console.WriteLine($"I am in {Location} and it is {GetWeatherCondition()}. {GetTemperatureCondition()}. The temperature in Fahrenheit is {FahrenheitTemp}.");
        }

        public void PrintCelciusWeatherReport()
        {
            Console.WriteLine($"I am in {Location} and it is {GetWeatherCondition()}. {GetTemperatureCondition()}. The temperature in Celcius is {Temperature}.");
        }

        private double ConvertCelciusToFahrenheit(double temperature)
        {
            return (9.0 / 5.0) * temperature + 32;
        }

        private string GetWeatherCondition()
        {
            if (Location == "London")
            {

                return "🌦";

            }
            else if (Location == "California")
            {

                return "🌅";

            }
            else if (Location == "Cape Town")
            {

                return "🌤";

            }
            return "🔆";
        }

        private string GetTemperatureCondition()
        {
            if (Temperature > THRESHOLD_HOT)
            {

                return "It's too hot 🥵!";

            }
            else if (Temperature < THRESHOLD_COLD)
            {

                return "It's too cold 🥶!";

            }
            return "Ahhh...it's just right 😊!";
        }

    }
}

