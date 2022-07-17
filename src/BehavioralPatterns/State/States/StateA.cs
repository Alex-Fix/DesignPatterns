namespace State.States;

internal class StateA : State
{
      internal override void Hanldle(Context context) => context.State = new StateB();
}
