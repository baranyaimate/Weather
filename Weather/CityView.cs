using System;
using System.Drawing;
using System.Globalization;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Weather
{
    public partial class CityView : Form
    {
        public CityView(City city)
        {
            InitializeComponent();
            CityNameLabel.Text = city.Name;
            LoadWeatherData(city);
        }

        private async void LoadWeatherData(City city)
        {
            HttpClient client = new HttpClient();
            var responseString = await client.GetStringAsync("https://api.openweathermap.org/data/2.5/weather?id=" + city.Id + "&APPID=0079a590cd56c31ffb2f4105946aeb6f&units=metric");

            dynamic weatherData = JObject.Parse(responseString);

            tempDataLabel.Text = Math.Round(float.Parse(weatherData.main.temp.ToString())) + "°C";
            feelsLikeDataLabel.Text = Math.Round(float.Parse(weatherData.main.feels_like.ToString())) + "°C";
            humidityDataLabel.Text = weatherData.main.humidity + "%";
            windDataLabel.Text = Math.Round(float.Parse(weatherData.wind.speed.ToString())) + " km/h";
            visibilityDataLabel.Text = float.Parse(weatherData.visibility.ToString()) / 1000 + " km";
            pressureDataLabel.Text = weatherData.main.pressure.ToString() + " hPa";
            sunriseDataLabel.Text = UnixTimeStampToDateTime(double.Parse(weatherData.sys.sunrise.ToString())).ToString("HH:mm");
            sunsetDataLabel.Text = UnixTimeStampToDateTime(double.Parse(weatherData.sys.sunset.ToString())).ToString("HH:mm");

            weatherIcon.Text = "";
            switch (weatherData.weather[0].icon.ToString())
            {
                case "01d": //Clear sky day
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530392 - weather.png");
                    break;
                case "01n": //Clear sky night
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530382 - weather.png");
                    break; 
                case "02d": //Few clouds day
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530391 - weather.png");
                    break;
                case "02n": //Few clouds night
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530383 - weather.png");
                    break; 
                case "03d": //Scattered clouds day
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530391 - weather.png");
                    break;
                case "03n": //Scattered clouds night
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530383 - weather.png");
                    break;
                case "04d": //Broken clouds day
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530369 - weather.png");
                    break;
                case "04n": //Broken clouds night
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530369 - weather.png");
                    break;
                case "09d": //Shower rain day
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530390 - weather.png");
                    break;
                case "09n": //Shower rain night
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530379 - weather.png");
                    break;
                case "10d": //Rain day
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530390 - weather.png");
                    break;
                case "10n": //Rain night
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530379 - weather.png");
                    break;
                case "11d": //Thunderstorm day
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530385 - weather.png");
                    break;
                case "11n": //Thunderstorm night
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530381 - weather.png");
                    break;
                case "13d": //Snow day
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530388 - weather.png");
                    break;
                case "13n": //Snow night
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530380 - weather.png");
                    break;
                case "50d": //Mist day
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530386 - weather.png");
                    break;
                case "50n": //Mist night
                    weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\256\1530377 - weather.png");
                    break;
                default:
                    weatherIcon.Text = "No image";
                    break;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new SelectCityView().Show();
            this.Hide();
        }
        
        private DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}