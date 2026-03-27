namespace SmartHome;

public class LightsSwitcher(string name)
{
    public void LightsOn(string sensorName, decimal value)
    {
        Console.WriteLine($"{name} Detected motion from {sensorName} with value {value} turning lights on");
    }
}

public class ConsoleLogger(string name)
{
    public void ConsoleLog(string sensorName, decimal value)
    {
        Console.WriteLine($"{name} Logging motion from {sensorName} with value {value}");
    }
}