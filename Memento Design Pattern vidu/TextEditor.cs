public class TextEditor
{
    public string Content { get; set; }

    public Memento Save()
    {
        return new Memento(Content);
    }

    public void Restore(Memento memento)
    {
        Content = memento.Content;
    }
}
