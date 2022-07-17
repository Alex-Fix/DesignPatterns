using Interpreter;
using Interpreter.Expressions;

Context context = new();

int x = 5;
int y = 8;
int z = 9;

context.SetVariable(nameof(x), x);
context.SetVariable(nameof(y), y);
context.SetVariable(nameof(z), z);

IExpression expression = new SubstractExpression(
      new AddExpresion(
            new NumberExpression(nameof(x)), new NumberExpression(nameof(y))
            ),
      new NumberExpression(nameof(z)));

int result = expression.Interpret(context);

Console.WriteLine(result);