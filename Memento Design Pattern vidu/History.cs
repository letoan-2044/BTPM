using System.Collections.Generic;

public class History
{
    private Stack<Memento> _mementos = new Stack<Memento>();

    public void Push(Memento memento)
    {
        _mementos.Push(memento);
    }

    public Memento Pop()
    {
        return _mementos.Pop();
    }
}
