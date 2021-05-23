using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Weather
{
    public partial class Form1 : Form
    {
        static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //var responseString = await client.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=pécs,hu&APPID=0079a590cd56c31ffb2f4105946aeb6f");
            
            //label1.Text = responseString;
            LoadCities();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.FromArgb(66, 134, 244),
                Color.FromArgb(55, 59, 68),
                90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private async void LoadCities()
        {
            StreamReader r = new StreamReader("C:/Users/mateb/Downloads/city.list.min.json");
            string jsonString = r.ReadToEnd();
            List<City> cityList = JsonConvert.DeserializeObject<List<City>>(jsonString);
            for (int i = 0; i < cityList.Count; i++)
            {
                listBox1.Items.Add(cityList[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(e);
        }
    }
    
    public class City
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}