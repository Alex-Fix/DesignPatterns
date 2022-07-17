namespace Interpreter.Expressions;

internal class AddExpresion : IExpression
{
      private readonly IExpression _leftExpression;
      private readonly IExpression _rightExpression;

      internal AddExpresion(IExpression leftExpression, IExpression rightExpression)
      {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
      }

      public int Interpret(Context context) => _leftExpression.Interpret(context) + _rightExpression.Interpret(context);
}
