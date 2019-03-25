﻿using AppWeather.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWeather
{
    public partial class Form3 : Form
    {
        string date, mintemp, maxtemp, pressure, wind, humidity, message, picture;

        public Form3(string date,string mintemp,string maxtemp,string pressure,string wind,string humidity
            ,string message,string picture)
        {
            InitializeComponent();
            this.date = date;
            this.mintemp = mintemp;
            this.maxtemp = maxtemp;
            this.pressure = pressure;
            this.wind = wind;
            this.humidity = humidity;
            this.message = message;
            this.picture = picture;
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            dateLabel.Text = date;
            minTemperatureLabel.Text = mintemp + " °C"; 
            maxTempLabel.Text = maxtemp + " °C"; 
            pressureLabel.Text = pressure + " hPa"; 
            WindSpeedLabel.Text = wind + " m/s"; 
            humidityLabel.Text = humidity + " %";
            descriptionLabel.Text = message.ToUpper();
            string img = "http://openweathermap.org/img/w/" + picture + ".png";
            pictureBox1.Load(img);
        }
    }
}
