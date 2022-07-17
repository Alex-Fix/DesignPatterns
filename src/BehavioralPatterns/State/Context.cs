using S = State.States;

namespace State;

internal class Context
{
      internal Context(S.State state)
      {
            State = state;
      }

      internal S.State State { get; set; }

      internal void Request()
      {
            Console.WriteLine($"Current state: {State.GetType().FullName}");
            State.Hanldle(this);
      }
}
