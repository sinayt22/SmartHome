using SmartHome;



var motionSensor = new MotionSensor();
var lightSwitchHandler = new LightsSwitcher("lights-001");
var consolerLogger = new ConsoleLogger("logger-001");

Console.WriteLine("Testing initial stage (no triggers)");
motionSensor.Detect();
Console.WriteLine("-----------------------------\n");

Console.WriteLine("Generating Motion....");
motionSensor.Trigger += lightSwitchHandler.LightsOn;
motionSensor.Trigger += consolerLogger.ConsoleLog;
motionSensor.Detect();
Console.WriteLine("-----------------------------\n");

Console.WriteLine("Turning off Lights");
motionSensor.Trigger -= lightSwitchHandler.LightsOn;
Console.WriteLine("Generating Motion....");
motionSensor.Detect();
Console.WriteLine("-----------------------------\n");

Console.WriteLine("Adding another console logger");
var consolerLogger2 = new ConsoleLogger("logger-002");
motionSensor.Trigger += consolerLogger2.ConsoleLog;
Console.WriteLine("Generating Motion....");
motionSensor.Detect();
Console.WriteLine("-----------------------------\n");

Console.WriteLine("Testing invoking delegate directly");
motionSensor.Trigger("no one", 1.3m);
Console.WriteLine("-----------------------------\n");


Console.WriteLine("Testing unsubscribing all");
motionSensor.Trigger -= consolerLogger.ConsoleLog;
motionSensor.Trigger -= consolerLogger2.ConsoleLog;
motionSensor.Trigger -= consolerLogger2.ConsoleLog;
motionSensor.Detect();
Console.WriteLine("-----------------------------\n");



