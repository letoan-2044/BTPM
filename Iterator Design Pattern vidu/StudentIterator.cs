using System.Collections.Generic;

public class StudentIterator : IIterator<Student>
{
    private List<Student> _students;
    private int _position = 0;

    public StudentIterator(List<Student> students)
    {
        _students = students;
    }

    public Student Current()
    {
        return _students[_position];
    }

    public bool MoveNext()
    {
        _position++;
        return _position < _students.Count;
    }

    public void Reset()
    {
        _position = 0;
    }
}
