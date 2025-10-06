using System.Linq.Expressions;
using DPM225500_DuongTriVi_Real01_Interpreter;

public class Program
{
    public static void Main(string[] args)
    {
        string roman = "MCMXXVIII";
        Context context = new Context(roman);
        // Build the 'parse tree'
        List<Expressions> tree = new List<Expressions>();
        tree.Add(new ThousandExpression());
        tree.Add(new HundredExpression());
        tree.Add(new TenExpression());
        tree.Add(new OneExpression());
       
        foreach (Expressions exp in tree)
        {
            exp.Interpret(context);
        }
        Console.WriteLine("{0} = {1}",
                roman, context.Output);
        // Wait for user
        Console.ReadKey();
    }
}