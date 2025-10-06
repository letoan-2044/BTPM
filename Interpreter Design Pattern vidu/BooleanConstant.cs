public class BooleanConstant : IExpression
{
    private bool _value;

    public BooleanConstant(bool value)
    {
        _value = value;
    }

    public bool Interpret()
    {
        return _value;
    }
}
