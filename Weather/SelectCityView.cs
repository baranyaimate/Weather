using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Weather
{
    public partial class SelectCityView : Form
    {
        private List<City> _cityList;
        public SelectCityView()
        {
            InitializeComponent();
        }

        private void SelectCityView_Load(object sender, EventArgs e)
        {
            LoadCities();
        }

        private void LoadCities()
        {
            StreamReader streamReader = new StreamReader(Application.StartupPath + @"..\..\..\res\city.list.r.json");
            string jsonString = streamReader.ReadToEnd();
            _cityList = JsonConvert.DeserializeObject<List<City>>(jsonString);
            if (_cityList != null)
            {
                foreach (var city in _cityList)
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
                Hide();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            cityListBox.Items.Clear();

            foreach (var city in _cityList) 
            {
                if (city.ToString().Contains(searchTextBox.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    cityListBox.Items.Add(city);
                }
            }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Equals("Search"))
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.White;
            }
        }
    }
}