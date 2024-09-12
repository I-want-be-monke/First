using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace pogoda
{
    public partial class MainPage : ContentPage
    {

        const string API = "722658571bfe09899d21e17114bfd46c";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void getter_Clicked(object sender, EventArgs e)
        {
            string city = Input.Text.Trim();
            if (city.Length <2)
            {
                await DisplayAlert("ERROR", "City used to be bigger", "Okay");
                return;
            }

            HttpClient client = new HttpClient();
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={API}&units=metric";
            string gets_resulr = await client.GetStringAsync(url);

            var json = JObject.Parse(gets_resulr);
            string temp = json["main"]["temp"].ToString();
            string wind = json["wind"]["speed"].ToString();
            string sky = json["weather"][0]["description"].ToString();

            string stroka = "Temperature: " + temp+"\n"+ "wind speed: " + wind + "m/s" + "\n" +sky;
            result.Text = stroka;

        }
    }
}
