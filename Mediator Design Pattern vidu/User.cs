using System;

public class User : IUser
{
    private ChatRoom _chatRoom;

    public string Name { get; private set; }

    public User(string name, ChatRoom chatRoom)
    {
        Name = name;
        _chatRoom = chatRoom;
        _chatRoom.RegisterUser(this);
    }

    public void Send(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        _chatRoom.SendMessage(message, this);
    }

    public void Receive(string message, IUser from)
    {
        Console.WriteLine($"{Name} received from {from.Name}: {message}");
    }
}
