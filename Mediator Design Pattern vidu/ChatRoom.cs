using System;
using System.Collections.Generic;

public class ChatRoom
{
    private List<IUser> _users = new List<IUser>();

    public void RegisterUser(IUser user)
    {
        if (!_users.Contains(user))
        {
            _users.Add(user);
            Console.WriteLine($"{user.Name} joined the chat room.");
        }
    }

    public void SendMessage(string message, IUser from)
    {
        foreach (var user in _users)
        {
            if (user != from)
                user.Receive(message, from);
        }
    }
}
