public class FanOffCommand : ICommand
{
    private Fan _fan;

    public FanOffCommand(Fan fan)
    {
        _fan = fan;
    }

    public void Execute()
    {
        _fan.Stop();
    }

    public void Undo()
    {
        _fan.Start();
    }
}
