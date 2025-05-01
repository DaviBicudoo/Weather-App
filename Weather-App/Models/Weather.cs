namespace Weather_App.Models
{
    public class Weather
    {
        public double Longitude { get; set; }
        public double Latitutde { get; set; }
        public int Visibility { get; set; }
        public double MaxTemperature { get; set; }
        public double MinTemperature { get; set; }
        public double Temperature { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
        public string? Main { get; set; }
        public string? Description { get; set; }
        public double WindSpeed { get; set; }
    }
}
