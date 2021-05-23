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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CityNameLabel
            // 
            this.CityNameLabel.Font = new System.Drawing.Font("Quicksand", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.CityNameLabel.Location = new System.Drawing.Point(115, 12);
            this.CityNameLabel.Name = "CityNameLabel";
            this.CityNameLabel.Size = new System.Drawing.Size(367, 63);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image) (resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 63);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TempWeatherData);
            this.Controls.Add(this.CityNameLabel);
            this.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CityView";
            this.Text = "Weather";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label TempWeatherData;

        private System.Windows.Forms.Label CityNameLabel;

        #endregion
    }
}