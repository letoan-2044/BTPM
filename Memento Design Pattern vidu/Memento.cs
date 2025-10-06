public class Memento
{
    public string Content { get; private set; }

    public Memento(string content)
    {
        Content = content;
    }
}
