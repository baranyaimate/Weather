using System.ComponentModel;

namespace Weather
{
    partial class CityView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityView));
            this.CityNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.weatherIcon = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.tempDataLabel = new System.Windows.Forms.Label();
            this.feelsLikeDataLabel = new System.Windows.Forms.Label();
            this.feelsLikeLabel = new System.Windows.Forms.Label();
            this.humidityDataLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.windDataLabel = new System.Windows.Forms.Label();
            this.visibilityLabel = new System.Windows.Forms.Label();
            this.visibilityDataLabel = new System.Windows.Forms.Label();
            this.sunriseLabel = new System.Windows.Forms.Label();
            this.sunriseDataLabel = new System.Windows.Forms.Label();
            this.sunsetLabel = new System.Windows.Forms.Label();
            this.sunsetDataLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.pressureDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CityNameLabel
            // 
            this.CityNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CityNameLabel.Font = new System.Drawing.Font("Quicksand", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.CityNameLabel.Location = new System.Drawing.Point(98, 9);
            this.CityNameLabel.Name = "CityNameLabel";
            this.CityNameLabel.Size = new System.Drawing.Size(367, 53);
            this.CityNameLabel.TabIndex = 0;
            this.CityNameLabel.Text = "City name";
            this.CityNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = ((System.Drawing.Image) (resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 50);
            this.backButton.TabIndex = 2;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // weatherIcon
            // 
            this.weatherIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weatherIcon.Location = new System.Drawing.Point(800, 199);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(280, 163);
            this.weatherIcon.TabIndex = 3;
            this.weatherIcon.Text = "weatherIcon";
            // 
            // tempLabel
            // 
            this.tempLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(114, 199);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(174, 32);
            this.tempLabel.TabIndex = 4;
            this.tempLabel.Text = "Temperature:";
            // 
            // tempDataLabel
            // 
            this.tempDataLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tempDataLabel.ForeColor = System.Drawing.Color.White;
            this.tempDataLabel.Location = new System.Drawing.Point(294, 199);
            this.tempDataLabel.Name = "tempDataLabel";
            this.tempDataLabel.Size = new System.Drawing.Size(117, 32);
            this.tempDataLabel.TabIndex = 5;
            this.tempDataLabel.Text = "10°C";
            // 
            // feelsLikeDataLabel
            // 
            this.feelsLikeDataLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.feelsLikeDataLabel.ForeColor = System.Drawing.Color.White;
            this.feelsLikeDataLabel.Location = new System.Drawing.Point(296, 245);
            this.feelsLikeDataLabel.Name = "feelsLikeDataLabel";
            this.feelsLikeDataLabel.Size = new System.Drawing.Size(117, 32);
            this.feelsLikeDataLabel.TabIndex = 7;
            this.feelsLikeDataLabel.Text = "10°C";
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.feelsLikeLabel.ForeColor = System.Drawing.Color.White;
            this.feelsLikeLabel.Location = new System.Drawing.Point(114, 245);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(145, 32);
            this.feelsLikeLabel.TabIndex = 6;
            this.feelsLikeLabel.Text = "Feels like:";
            // 
            // humidityDataLabel
            // 
            this.humidityDataLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.humidityDataLabel.ForeColor = System.Drawing.Color.White;
            this.humidityDataLabel.Location = new System.Drawing.Point(296, 288);
            this.humidityDataLabel.Name = "humidityDataLabel";
            this.humidityDataLabel.Size = new System.Drawing.Size(117, 32);
            this.humidityDataLabel.TabIndex = 9;
            this.humidityDataLabel.Text = "50%";
            // 
            // humidityLabel
            // 
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(114, 288);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(127, 32);
            this.humidityLabel.TabIndex = 10;
            this.humidityLabel.Text = "Humidity:";
            // 
            // windLabel
            // 
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.windLabel.ForeColor = System.Drawing.Color.White;
            this.windLabel.Location = new System.Drawing.Point(114, 330);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(103, 32);
            this.windLabel.TabIndex = 12;
            this.windLabel.Text = "Wind:";
            // 
            // windDataLabel
            // 
            this.windDataLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.windDataLabel.ForeColor = System.Drawing.Color.White;
            this.windDataLabel.Location = new System.Drawing.Point(294, 330);
            this.windDataLabel.Name = "windDataLabel";
            this.windDataLabel.Size = new System.Drawing.Size(117, 32);
            this.windDataLabel.TabIndex = 11;
            this.windDataLabel.Text = "10km/h";
            // 
            // visibilityLabel
            // 
            this.visibilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.visibilityLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.visibilityLabel.ForeColor = System.Drawing.Color.White;
            this.visibilityLabel.Location = new System.Drawing.Point(419, 199);
            this.visibilityLabel.Name = "visibilityLabel";
            this.visibilityLabel.Size = new System.Drawing.Size(127, 32);
            this.visibilityLabel.TabIndex = 14;
            this.visibilityLabel.Text = "Visibility:";
            // 
            // visibilityDataLabel
            // 
            this.visibilityDataLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.visibilityDataLabel.ForeColor = System.Drawing.Color.White;
            this.visibilityDataLabel.Location = new System.Drawing.Point(592, 199);
            this.visibilityDataLabel.Name = "visibilityDataLabel";
            this.visibilityDataLabel.Size = new System.Drawing.Size(117, 32);
            this.visibilityDataLabel.TabIndex = 13;
            this.visibilityDataLabel.Text = "10km";
            // 
            // sunriseLabel
            // 
            this.sunriseLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunriseLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.sunriseLabel.ForeColor = System.Drawing.Color.White;
            this.sunriseLabel.Location = new System.Drawing.Point(419, 288);
            this.sunriseLabel.Name = "sunriseLabel";
            this.sunriseLabel.Size = new System.Drawing.Size(116, 32);
            this.sunriseLabel.TabIndex = 16;
            this.sunriseLabel.Text = "Sunrise:";
            // 
            // sunriseDataLabel
            // 
            this.sunriseDataLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.sunriseDataLabel.ForeColor = System.Drawing.Color.White;
            this.sunriseDataLabel.Location = new System.Drawing.Point(592, 288);
            this.sunriseDataLabel.Name = "sunriseDataLabel";
            this.sunriseDataLabel.Size = new System.Drawing.Size(117, 32);
            this.sunriseDataLabel.TabIndex = 15;
            this.sunriseDataLabel.Text = "06:00";
            // 
            // sunsetLabel
            // 
            this.sunsetLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunsetLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.sunsetLabel.ForeColor = System.Drawing.Color.White;
            this.sunsetLabel.Location = new System.Drawing.Point(419, 330);
            this.sunsetLabel.Name = "sunsetLabel";
            this.sunsetLabel.Size = new System.Drawing.Size(103, 32);
            this.sunsetLabel.TabIndex = 18;
            this.sunsetLabel.Text = "Sunset:";
            // 
            // sunsetDataLabel
            // 
            this.sunsetDataLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.sunsetDataLabel.ForeColor = System.Drawing.Color.White;
            this.sunsetDataLabel.Location = new System.Drawing.Point(592, 330);
            this.sunsetDataLabel.Name = "sunsetDataLabel";
            this.sunsetDataLabel.Size = new System.Drawing.Size(117, 32);
            this.sunsetDataLabel.TabIndex = 17;
            this.sunsetDataLabel.Text = "20:00";
            // 
            // pressureLabel
            // 
            this.pressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.pressureLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.pressureLabel.ForeColor = System.Drawing.Color.White;
            this.pressureLabel.Location = new System.Drawing.Point(419, 245);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(127, 32);
            this.pressureLabel.TabIndex = 20;
            this.pressureLabel.Text = "Pressure:";
            // 
            // pressureDataLabel
            // 
            this.pressureDataLabel.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.pressureDataLabel.ForeColor = System.Drawing.Color.White;
            this.pressureDataLabel.Location = new System.Drawing.Point(592, 245);
            this.pressureDataLabel.Name = "pressureDataLabel";
            this.pressureDataLabel.Size = new System.Drawing.Size(117, 32);
            this.pressureDataLabel.TabIndex = 19;
            this.pressureDataLabel.Text = "1020 hPa";
            // 
            // CityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (42)))), ((int) (((byte) (111)))), ((int) (((byte) (151)))));
            this.ClientSize = new System.Drawing.Size(1194, 671);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.pressureDataLabel);
            this.Controls.Add(this.sunsetLabel);
            this.Controls.Add(this.sunsetDataLabel);
            this.Controls.Add(this.sunriseLabel);
            this.Controls.Add(this.sunriseDataLabel);
            this.Controls.Add(this.visibilityLabel);
            this.Controls.Add(this.visibilityDataLabel);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.windDataLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.humidityDataLabel);
            this.Controls.Add(this.feelsLikeDataLabel);
            this.Controls.Add(this.feelsLikeLabel);
            this.Controls.Add(this.tempDataLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.CityNameLabel);
            this.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "CityView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label pressureDataLabel;

        private System.Windows.Forms.Label sunriseLabel;
        private System.Windows.Forms.Label sunriseDataLabel;
        private System.Windows.Forms.Label sunsetLabel;
        private System.Windows.Forms.Label sunsetDataLabel;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label visibilityLabel;
        private System.Windows.Forms.Label visibilityDataLabel;

        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label windDataLabel;

        private System.Windows.Forms.Label humidityLabel;

        private System.Windows.Forms.Label humidityDataLabel;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label feelsLikeDataLabel;
        private System.Windows.Forms.Label feelsLikeLabel;

        private System.Windows.Forms.Label tempDataLabel;

        private System.Windows.Forms.Label tempLabel;

        private System.Windows.Forms.Label weatherIcon;

        private System.Windows.Forms.Button backButton;

        private System.Windows.Forms.Label CityNameLabel;

        #endregion
    }
}