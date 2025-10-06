using System;

class Program
{
    static void Main(string[] args)
    {
        // true AND false
        IExpression expr1 = new AndExpression(
            new BooleanConstant(true),
            new BooleanConstant(false)
        );

        // true OR false
        IExpression expr2 = new OrExpression(
            new BooleanConstant(true),
            new BooleanConstant(false)
        );

        // NOT true
        IExpression expr3 = new NotExpression(
            new BooleanConstant(true)
        );

        Console.WriteLine("true AND false = " + expr1.Interpret());  // false
        Console.WriteLine("true OR false = " + expr2.Interpret());   // true
        Console.WriteLine("NOT true = " + expr3.Interpret());        // false

        Console.ReadKey();
    }
}
