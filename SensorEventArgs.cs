namespace SmartHome;

public class SensorEventArgs : EventArgs
{
    public required string SensorName { get; init; }
    public double Value { get; init; }
    public DateTime TimeStamp { get; init; }
}