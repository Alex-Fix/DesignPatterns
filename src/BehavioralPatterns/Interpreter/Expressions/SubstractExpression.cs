namespace Interpreter.Expressions;

internal class SubstractExpression : IExpression
{
      private readonly IExpression _leftExpression;
      private readonly IExpression _rightExpression;

      internal SubstractExpression(IExpression leftExpression, IExpression rightExpression)
      {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
      }

      public int Interpret(Context context) => _leftExpression.Interpret(context) - _rightExpression.Interpret(context);
}