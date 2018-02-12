using System;
namespace NationalParkGeeks.Models
{
    public class Weather
    {
        private int FiveDayForecastValue { get; set; }
        private int High { get; set; }
        private int Low { get; set; }
        private string Forecast { get; set; }
        private string WeatherMessage;

        public Weather()
        {
        }

        public String GetWeatherMessage()
        {

            if (Forecast.Equals("snow", StringComparison.InvariantCultureIgnoreCase))
            {
                if (High < 20 || Low < 20)
                {
                    WeatherMessage = "Pack snowshoes and beware exposure to frigid temperatures.";
                }
                else if (High - Low > 20)
                {
                    WeatherMessage = "Pack snowshoes and wear breathable layers.";
                }
                else if ((High - Low > 20) && High > 75)
                {
                    WeatherMessage = "Pack snowshoes,wear breathable layers and bring an extra gallon of water.";
                }
                else if (High > 75)
                {
                    WeatherMessage = "Pack snowshoes and bring an extra gallon of water.";
                }
                else
                {
                    WeatherMessage = "Pack snowshoes";
                }
            }
            else if (Forecast.Equals("rain", StringComparison.InvariantCultureIgnoreCase))
            {
                if (High < 20 || Low < 20)
                {
                    WeatherMessage = "Pack rain gear and waterproof shoes. Beware of exposure to frigid temperatures.";
                }
                else if (High - Low > 20)
                {
                    WeatherMessage = "Pack rain gear and waterproof shoes. Wear breathable layers.";
                }
                else if ((High - Low > 20) && High > 75)
                {
                    WeatherMessage = "Pack rain gear,waterproof shoes, wear breathable layers and bring an extra gallon of water.";
                }
                else if (High > 75)
                {
                    WeatherMessage = "Pack rain gear,waterproof shoes and bring an extra gallon of water.";
                }
                else
                {
                    WeatherMessage = "Pack rain gear and waterproof shoes.";
                }
            }
            else if (Forecast.Equals("thunderstorms", StringComparison.InvariantCultureIgnoreCase))
            {
                if (High < 20 || Low < 20)
                {
                    WeatherMessage = "Seek shelter and avoid hiking on exposed ridges. Beware of exposure to frigid temperatures.";
                }
                else if (High - Low > 20)
                {
                    WeatherMessage = "Seek shelter and avoid hiking on exposed ridges. Wear breathable layers.";
                }
                else if ((High - Low > 20) && High > 75)
                {
                    WeatherMessage = "Seek shelter and avoid hiking on exposed ridges. Wear breathble layers and bring an extra gallon of water.";
                }
                else if (High > 75)
                {
                    WeatherMessage = "Seek shelter and avoid hiking on exposed ridges. Bring an extra gallon of water.";
                }
                else
                {
                    WeatherMessage = "Seek shelter and avoid hiking on exposed ridges";
                }
            }
            else if (Forecast.Equals("sunny", StringComparison.InvariantCultureIgnoreCase))
            {
                if (High < 20 || Low < 20)
                {
                    WeatherMessage = "Pack sunblock. Beware of exposure to frigid temperatures.";
                }
                else if (High - Low > 20)
                {
                    WeatherMessage = "Pack sunblock. Wear breathable layers.";
                }
                else if ((High - Low > 20) && High > 75)
                {
                    WeatherMessage = "Pack sunblock, wear breathable layers and bring an extra gallon of water.";
                }
                else if (High > 75)
                {
                    WeatherMessage = "Pack sunblock and bring an extra gallon of water.";
                }
                else
                {
                    WeatherMessage = "Pack sunblock";
                }
            }
            else
            {
                if (High < 20 || Low < 20)
                {
                    WeatherMessage = "Beware of exposure to frigid temperatures.";
                }
                else if (High - Low > 20)
                {
                    WeatherMessage = "Wear breathable layers.";
                }
                else if ((High - Low > 20) && High > 75)
                {
                    WeatherMessage = "Wear breathable layers and bring an extra gallon of water.";
                }
                else if (High > 75)
                {
                    WeatherMessage = "Bring an extra gallon of water.";
                }
            }

            return WeatherMessage;
        }

        public string SetWeatherMessage(string WeatherMessage) => this.WeatherMessage = WeatherMessage;

        public string GetParsedForecast()
        {
            string ParsedForecast = Forecast.Replace(" ", "");
            return ParsedForecast;
        }
    }

}
