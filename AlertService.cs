namespace SmartHome;

public static class EventLogger
{
    public static void LogEvent(SensorEventArgs e)
    {
        Console.WriteLine("=== Event Logger - Logging event ===");
        Console.WriteLine($"Sensor: '{e.SensorName}' detected value: '{e.Value}'");
        Console.WriteLine($"Time of detection: {e.TimeStamp}");
    }
}

public class AlertService
{
    public Action<SensorEventArgs>? LogAction;
    public void OnSensorDetected(object? sender, SensorEventArgs e)
    {
        if (e.SensorName == "Motion")
        {
            Console.WriteLine($"Detected motion in the room with value of '{e.Value}' at time: {e.TimeStamp}");
        }
        else if (e.SensorName == "Temperature")
        {
            Console.WriteLine($"Detected a change in temperature above threshold. value: '{e.Value}' at time {e.TimeStamp}");
        }
        LogAction?.Invoke(e);
    }
}

