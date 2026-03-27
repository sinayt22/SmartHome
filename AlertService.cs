namespace SmartHome;

public class EventCounter
{
    public int Count { get; protected set; }
    public void ProcessSensorEvent(SensorEventArgs e)
    {
        Count += 1;
    }
}

public class AlertService(Action<SensorEventArgs>? postProcess)
{
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
        postProcess?.Invoke(e);
    }
}

