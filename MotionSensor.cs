namespace SmartHome;

public class MotionSensor
{
    public event EventHandler<SensorEventArgs>? Triggered;

    public void Detect(double reading)
    {
        Triggered?.Invoke(this, new SensorEventArgs {SensorName = "Motion", Value = reading, TimeStamp = DateTime.Now});
    }
}

