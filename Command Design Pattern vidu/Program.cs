using System;

class Program
{
    static void Main()
    {
        // Các thiết bị
        Light light = new Light();
        Fan fan = new Fan();

        // Các lệnh
        ICommand lightOn = new LightOnCommand(light);
        ICommand lightOff = new LightOffCommand(light);
        ICommand fanOn = new FanOnCommand(fan);
        ICommand fanOff = new FanOffCommand(fan);

        // Remote control
        RemoteControl remote = new RemoteControl();

        // Bật đèn
        remote.SetCommand(lightOn);
        remote.PressButton();      // 💡 Light is ON
        remote.PressUndo();        // 💡 Light is OFF

        // Bật quạt
        remote.SetCommand(fanOn);
        remote.PressButton();      // 🌀 Fan is running
        remote.PressUndo();        // 🌀 Fan is stopped

        // Tắt đèn
        remote.SetCommand(lightOff);
        remote.PressButton();      // 💡 Light is OFF
        remote.PressUndo();        // 💡 Light is ON

        Console.ReadKey();
    }
}
