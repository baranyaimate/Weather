using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCities();
        }

        private void LoadCities()
        {
            StreamReader r = new StreamReader(Application.StartupPath + @"..\..\..\res\city.list.min.json");
            string jsonString = r.ReadToEnd();
            List<City> cityList = JsonConvert.DeserializeObject<List<City>>(jsonString);
            if (cityList != null)
            {
                foreach (var city in cityList)
                {
                    cityListBox.Items.Add(city);
                } 
            }
        }

        private void cityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cityListBox.SelectedItem != null)
            {
                new CityView((City) cityListBox.SelectedItem).Show();
                this.Hide();
            }
        }
    }
}