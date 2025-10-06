using DPM225500_DuongTriVi_Pattern01_Interpreter;

namespace Structural
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Context context = new Context();

            List<AbstractExpression> list = new List<AbstractExpression>();

            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            Console.ReadKey();
        }
    }
}
