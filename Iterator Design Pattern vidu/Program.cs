using System;

class Program
{
    static void Main()
    {
        StudentCollection students = new StudentCollection();
        students.AddStudent(new Student("Alice"));
        students.AddStudent(new Student("Bob"));
        students.AddStudent(new Student("Charlie"));
        students.AddStudent(new Student("Diana"));

        var iterator = students.CreateIterator();

        iterator.Reset(); // đảm bảo bắt đầu từ đầu

        Console.WriteLine("Danh sách học sinh:");

        do
        {
            Console.WriteLine("- " + iterator.Current().Name);
        }
        while (iterator.MoveNext());

        Console.ReadKey();
    }
}
