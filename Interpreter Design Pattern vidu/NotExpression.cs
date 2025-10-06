public class NotExpression : IExpression
{
    private IExpression _expression;

    public NotExpression(IExpression expression)
    {
        _expression = expression;
    }

    public bool Interpret()
    {
        return !_expression.Interpret();
    }
}
