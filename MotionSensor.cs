namespace SmartHome;
public delegate void SensorTrigger(string sensorName, decimal value);

public class MotionSensor
{
    public SensorTrigger? Trigger;

    public void Detect()
    {
        if (Trigger != null)
            Trigger("Motion", 12.3m);
        else
            Console.WriteLine("No Triggers");
    }
}

