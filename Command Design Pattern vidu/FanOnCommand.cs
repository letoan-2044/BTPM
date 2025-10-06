public class FanOnCommand : ICommand
{
    private Fan _fan;

    public FanOnCommand(Fan fan)
    {
        _fan = fan;
    }

    public void Execute()
    {
        _fan.Start();
    }

    public void Undo()
    {
        _fan.Stop();
    }
}
