public class Outdoor : Event
{
    private string _weatherForcast = "76°F - 🌤️ Partly Cloudy";

    public Outdoor()
    {
        SetEventType("Outdoor");
    }

    private string GetWeatherForecast()
    {
        return _weatherForcast;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"Weather Forecast ⛅️: {GetWeatherForecast()}\n");
        DisplayStandardDetails();
    }
}