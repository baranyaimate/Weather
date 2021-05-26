using System;
using System.Drawing;
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
            var responseString = await client.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?id=" + city.Id + "&APPID=0079a590cd56c31ffb2f4105946aeb6f&units=metric");

            dynamic weatherDatas = JArray.Parse("[" + responseString + "]");

            dynamic weatherData = weatherDatas[0];
  
            TempWeatherData.Text = weatherData.main.temp + "°C";

            weatherIcon.Text = "";
            weatherIcon.Image = Image.FromFile(Application.StartupPath + @"..\..\..\res\PNG\128\1530364 - weather.png");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        
    }
}