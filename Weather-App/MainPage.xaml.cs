using System.Threading.Tasks;
using Weather_App.Models;
using Weather_App.Services;

namespace Weather_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async Task searchButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(cityEntry.Text))
                { 
                    Weather? weather = await DataService.GetWeather(cityEntry.Text);

                    if (weather != null)
                    {
                        string? weatherData = "";

                        weatherData = $"Latitude: {weather.Latitude}\n" +
                                      $"Longitude: {weather.Longitude}\n" +
                                      $"Temperature: {weather.Temperature}°C\n" +
                                      $"Max Temperature: {weather.MaxTemperature}°C\n" +
                                      $"Min Temperature: {weather.MinTemperature}%\n" +
                                      $"Main: {weather.Main} hPa\n" +
                                      $"Description: {weather.Description} m/s\n" +
                                      $"Sunrise: {weather.Sunrise}\n" +
                                      $"Sunset: {weather.Sunset}\n" +
                                      $"Visibility: {weather.Visibility}\n" +
                                      $"Wind Speed: {weather.WindSpeed} m/s\n";
                    }
                    else
                    {
                        responseLabel.Text = "No forecast data.";
                    }
                }
                else
                {
                    responseLabel.Text = "Please enter a city name.";
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
