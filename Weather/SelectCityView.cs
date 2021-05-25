using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(1, 58, 99);
            cityListBox.BackColor = Color.FromArgb(1, 79, 134);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCities();
        }

        private void LoadCities()
        {
            StreamReader r = new StreamReader("C:/Users/mateb/Downloads/city.list.min.json");
            string jsonString = r.ReadToEnd();
            List<City> cityList = JsonConvert.DeserializeObject<List<City>>(jsonString);
            if (cityList != null)
            {
                for (int i = 0; i < cityList.Count; i++)
                {
                    cityListBox.Items.Add(cityList[i]);
                }
            }
        }

        private void cityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new CityView((City) cityListBox.SelectedItem).Show();
            this.Hide();
        }
    }
}