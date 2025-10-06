using System;

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();
        History history = new History();

        editor.Content = "Hello";
        history.Push(editor.Save());

        editor.Content = "Hello, World!";
        history.Push(editor.Save());

        editor.Content = "Hello, World! How are you?";
        history.Push(editor.Save());

        Console.WriteLine("Current content: " + editor.Content);

        // Undo 1 lần
        editor.Restore(history.Pop());
        Console.WriteLine("After undo 1: " + editor.Content);

        // Undo 2 lần
        editor.Restore(history.Pop());
        Console.WriteLine("After undo 2: " + editor.Content);

        Console.ReadKey();
    }
}
