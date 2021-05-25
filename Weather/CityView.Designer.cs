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
            this.TempWeatherData = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.weatherIcon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CityNameLabel
            // 
            this.CityNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CityNameLabel.Font = new System.Drawing.Font("Quicksand", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.CityNameLabel.Location = new System.Drawing.Point(98, 9);
            this.CityNameLabel.Name = "CityNameLabel";
            this.CityNameLabel.Size = new System.Drawing.Size(367, 53);
            this.CityNameLabel.TabIndex = 0;
            this.CityNameLabel.Text = "City name";
            this.CityNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TempWeatherData
            // 
            this.TempWeatherData.Location = new System.Drawing.Point(259, 304);
            this.TempWeatherData.Name = "TempWeatherData";
            this.TempWeatherData.Size = new System.Drawing.Size(590, 305);
            this.TempWeatherData.TabIndex = 1;
            this.TempWeatherData.Text = "label1";
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
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // weatherIcon
            // 
            this.weatherIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weatherIcon.Location = new System.Drawing.Point(98, 97);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(150, 100);
            this.weatherIcon.TabIndex = 3;
            this.weatherIcon.Text = "weatherIcon";
            // 
            // CityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (192)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.TempWeatherData);
            this.Controls.Add(this.CityNameLabel);
            this.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CityView";
            this.Text = "Weather";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label weatherIcon;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button backButton;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label TempWeatherData;

        private System.Windows.Forms.Label CityNameLabel;

        #endregion
    }
}