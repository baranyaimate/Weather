using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Net.Http;
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

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.FromArgb(66, 134, 244),
                Color.FromArgb(55, 59, 68),
                90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            listBox1.BackColor = Color.FromArgb(66, 134, 244);
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
                    listBox1.Items.Add(cityList[i]);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<CityView>().FirstOrDefault();
            if (form == null)
            {
                form = new CityView((City) listBox1.SelectedItem);
                form.Show();
            }

            form.Activate();
            this.Hide();
        }
    }
}