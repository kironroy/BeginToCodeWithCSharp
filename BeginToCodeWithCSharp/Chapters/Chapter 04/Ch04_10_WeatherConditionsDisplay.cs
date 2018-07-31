using SnapsLibrary;

class Ch04_10_WeatherConditionsDisplay
{
    public void StartProgram()
    {
        string conditions = SnapsEngine.GetWeatherConditionsDescription(latitude: 33.8032, longitude: 118.0719);
        SnapsEngine.DisplayString(conditions);
    }
}