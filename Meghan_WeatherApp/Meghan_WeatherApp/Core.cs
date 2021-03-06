﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Meghan_WeatherApp
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string zipCode)
        {
            string key = "e26dc9e5f21299e959b2199e01b992d6";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?zip=" + zipCode 
                + ",us&appid=" + key + "&units=imperial";

            JObject results = await DataService.getDataFromService(queryString).ConfigureAwait(false);

            if(results["weather"] != null)
            {
                Weather weather = new Weather();
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + "F";
                weather.Wind = (string)results["wind"]["speed"] + "mph";
                weather.Humidity = (string)results["main"]["humidity"] + "%";
                weather.Visibility = (string)results["weather"][0]["main"];

                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + "UTC";
                weather.Sunset = sunset.ToString() + "UTC";
                return weather;
            }
            else
            {
                return null;
            }
        }
    }
}
