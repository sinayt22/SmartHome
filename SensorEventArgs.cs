namespace SmartHome;

public class SensorEventArgs : EventArgs
{
    public required string SensorName { get; set; }
    public double Value { get; set; }
    public DateTime TimeStamp { get; set; }
}