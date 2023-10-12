namespace hw.DTOs.Forecast
{
    public class AddForecastDTO
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public float Temperature { get; set; }
        public ETemperatureUnit TemperatureUnit { get; set; } = ETemperatureUnit.Celcius;
    }
}