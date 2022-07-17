namespace Interpreter.Expressions;

internal interface IExpression
{
      int Interpret(Context context);
}

internal class NumberExpression : IExpression
{
      private readonly string _name;

      internal NumberExpression(string name)
      {
            _name = name;
      }

      public int Interpret(Context context) => context.GetVariable(_name);
}
