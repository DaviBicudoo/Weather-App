namespace Weather_App.Models
{
    public class Weather
    {
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public int? Visibility { get; set; }
        public double? MaxTemperature { get; set; }
        public double? MinTemperature { get; set; }
        public double? Temperature { get; set; }
        public string? Sunrise { get; set; }
        public string? Sunset { get; set; }
        public string? Main { get; set; }
        public string? Description { get; set; }
        public double? WindSpeed { get; set; }
    }
}
