using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Weather
{
    public partial class CityView : Form
    {
        public CityView(City city)
        {
            InitializeComponent();
            CityNameLabel.Text = city.Name;
            this.BackColor = Color.FromArgb(1, 58, 99);
            LoadWeatherData(city);
        }

        private async void LoadWeatherData(City city)
        {
            HttpClient client = new HttpClient();
            var responseString = await client.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?id=" + city.Id + "&APPID=0079a590cd56c31ffb2f4105946aeb6f&units=metric");
            //TempWeatherData.Text = responseString;

            dynamic weatherDatas = JArray.Parse("[" + responseString + "]");

            dynamic weatherData = weatherDatas[0];
  
            TempWeatherData.Text = weatherData.weather[0].main;

            weatherIcon.Text = "";
            weatherIcon.Image = Image.FromFile("C:/Users/mateb/Downloads/Weather/PNG/128/1530364 - weather.png");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        
        
    }
}