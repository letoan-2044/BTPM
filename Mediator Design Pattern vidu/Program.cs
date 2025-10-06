using System;

class Program
{
    static void Main()
    {
        ChatRoom chatRoom = new ChatRoom();

        IUser alice = new User("Alice", chatRoom);
        IUser bob = new User("Bob", chatRoom);
        IUser charlie = new User("Charlie", chatRoom);

        alice.Send("Hello everyone!");
        bob.Send("Hi Alice!");
        charlie.Send("Hey all!");

        Console.ReadKey();
    }
}
