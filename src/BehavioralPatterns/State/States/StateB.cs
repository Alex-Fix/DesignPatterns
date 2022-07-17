namespace State.States;

internal class StateB : State
{
      internal override void Hanldle(Context context) => context.State = new StateA();
}