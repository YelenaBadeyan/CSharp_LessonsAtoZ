using System;

namespace WeatherEnumExample
{
    // Declare an enum representing different weather conditions
    enum WeatherCondition
    {
        Sunny,
        Cloudy,
        Rainy
    }

    class Program
    {
        static void Main(string[] args)
        {
            WeatherCondition todayWeather = WeatherCondition.Cloudy;

            switch (todayWeather)
            {

                case WeatherCondition.Sunny:
                    Console.WriteLine("It's a sunny day today!");
                    break;
                case WeatherCondition.Cloudy:
                    Console.WriteLine("It's a cloudy day today.");
                    break;
                case WeatherCondition.Rainy:
                    Console.WriteLine("It's a rainy day today.");
                    break;
                default:
                    Console.WriteLine("Unknown weather condition.");
                    break;
            }
        }
    }
}
