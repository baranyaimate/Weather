using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

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
            TempWeatherData.Text = responseString;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: debug
            var form = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form == null)
            {
                form = new Form1();
                form.Show();
            }

            form.Activate();
            this.Hide();
        }
    }
}