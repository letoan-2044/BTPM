using System.Collections.Generic;

public class StudentCollection : IAggregate<Student>
{
    private List<Student> _students = new List<Student>();

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public Student GetAt(int index)
    {
        return _students[index];
    }

    public int Count => _students.Count;

    public IIterator<Student> CreateIterator()
    {
        return new StudentIterator(_students);
    }
}
