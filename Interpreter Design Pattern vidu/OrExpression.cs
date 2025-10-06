public class OrExpression : IExpression
{
    private IExpression _left;
    private IExpression _right;

    public OrExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public bool Interpret()
    {
        return _left.Interpret() || _right.Interpret();
    }
}
