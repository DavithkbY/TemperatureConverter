namespace View
{
    public interface ITemperatureScale
    {
        string Name { get; }

        double ConvertToKelvin(double temperature);

        double ConvertFromKelvin(double temperature);
    }
}