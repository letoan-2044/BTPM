public interface IUser
{
    string Name { get; }
    void Receive(string message, IUser from);
    void Send(string message);
}
