


using System.Reflection.Metadata.Ecma335;

class WeatherData
{
    private double temperature;
    private double humidity;
    private char scale;

    public WeatherData(double temperature = 0, double humidity = 0, char scale = 'C')
    {
        SetTemperature(temperature);
        SetHumidity(humidity);
        SetScale(scale);
}
    public void SetTemperature(double temperature)
    {
        if (temperature > -60 && temperature < 60)
        {
            this.temperature = temperature;
        }
        else
        {
            Console.WriteLine("Error! Value must be between -60°C and 60°C (-76°F and 140°F). Check your data.");
        }
    }
    public void SetHumidity(double humidity)
    {
        if (humidity >= 0 && humidity <= 100)
        {
            this.humidity = humidity;
        }
        else 
        { 
            Console.WriteLine("Error! Value must be between 0% and 100%. Check your data.");
        }
    }
    public void SetScale(char scale)
    {
        if (scale == 'C' || scale == 'F')
        {
            this.scale = scale;
        }
        else
        {
            Console.WriteLine("Error! Use 'C' for Celsius or 'F' for Fahrenheit. Try again");
        }
    }
    public void Convert()
    {
        if (scale == 'C')
        {
            temperature = (temperature * 9 / 5);
            scale = 'F';
        }
        if (scale == 'F')
        {
            temperature = (temperature - 32) * 5 / 9;
            scale = 'C';
        }
    }
    public override string ToString()
    {
        return $"Temperature: {temperature}°{scale}, Humidity: {humidity}%";
    }



      static void Main()
     {
         WeatherData weather = new WeatherData(33, 21, 'C');
         Console.WriteLine(weather);
         weather.Convert();
         Console.WriteLine(weather);
         weather.SetTemperature(150);
         weather.SetHumidity(-10);
         weather.SetScale('B');
     }


}