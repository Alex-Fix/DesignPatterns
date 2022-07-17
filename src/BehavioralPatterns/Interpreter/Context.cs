namespace Interpreter;

internal class Context
{
      private readonly Dictionary<string, int> _variables = new();

      internal int GetVariable(string name) => _variables[name];

      internal void SetVariable(string name, int value) => _variables[name] = value;
}
