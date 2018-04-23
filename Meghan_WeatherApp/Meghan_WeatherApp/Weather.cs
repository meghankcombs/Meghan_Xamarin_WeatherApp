using System;
using System.Collections.Generic;
using System.Text;

namespace Meghan_WeatherApp
{
    public class Weather
    {
        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Humidity { get; set; }
        public string Visibility { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }

        public Weather()
        {
            //Labels are bound to properties, so set to empty strings so labels show up on all platforms
            this.Title = "";
            this.Temperature = "";
            this.Wind = "";
            this.Humidity = "";
            this.Visibility = "";
            this.Sunrise = "";
            this.Sunset = "";
        }
    }
}
