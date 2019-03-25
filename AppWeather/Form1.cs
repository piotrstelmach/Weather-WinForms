using AppWeather.Api;
using AppWeather.Model;
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
    
    public partial class Form1 : Form
    {
        private WeatherModel.RootObject data;
        private string cityName;
        public Form1()
        {
            InitializeComponent();
            
        }

        public void prepareWeatherToDisplay(string City)
        {
            data = WeatherApi.getOneDayWeather(City);
        }

        public void displayWeather()
        {
            dateLabel.Visible = true;
            temperatureL.Visible = true;
            pressureL.Visible = true;
            WindSpeedL.Visible = true;
            weatherIconBox.Visible = true;
            descriptionLabel.Visible = true;
            temperatureLabel.Visible = true;
            pressureLabel.Visible = true;
            WindSpeedLabel.Visible = true;
            getFiveDay.Visible = true;

            dateLabel.Text = DateTime.Now.ToString();
            temperatureLabel.Text = data.main.temp.ToString()+ " °C";
            pressureLabel.Text = data.main.pressure.ToString()+" hPa";
            WindSpeedLabel.Text = data.wind.speed.ToString()+" m/s";
            descriptionLabel.Text = data.weather[0].description.ToUpper();
            string imgUrl = "http://openweathermap.org/img/w/" + data.weather[0].icon+".png";
            weatherIconBox.Load(imgUrl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
                cityName = searchTextBox.Text;
            if (cityName != "")
            {
                prepareWeatherToDisplay(cityName);
                if (data == null)
                {
                    MessageBox.Show("City name is incorrect or not found");
                }else displayWeather();
            }
            else
            {
                MessageBox.Show("Please enter city!");
            }

        }

        private void getFiveDay_Click(object sender, EventArgs e)
        {
                Form2 form = new Form2(cityName);
                form.Show();
        }
    }
}
