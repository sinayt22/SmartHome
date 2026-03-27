namespace SmartHome;

public class TemperatureSensor(double threshold)
{
    public event EventHandler<SensorEventArgs>? Triggered;

    public void Detect(double reading)
    {
        if (reading > threshold)
            Triggered?.Invoke(this, new SensorEventArgs {SensorName = "Temperature", Value = reading, TimeStamp = DateTime.Now});
    }
}