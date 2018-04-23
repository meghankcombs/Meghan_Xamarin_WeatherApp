using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Meghan_WeatherApp
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WeatherPage : ContentPage
	{
		public WeatherPage()
		{
			InitializeComponent();
            this.Title = "Meghan's Weather App";
            getWeatherBtn.Clicked += GetWeatherBtn_Clicked;

            //default binding set to default object
            this.BindingContext = new Weather();
		}

        private async void GetWeatherBtn_Clicked(object sender, EventArgs e)
        {
            Weather weather = await Core.GetWeather("60601");
            getWeatherBtn.Text = weather.Title;
        }
	}
}