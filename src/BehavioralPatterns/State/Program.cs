using State;
using State.States;

Context context = new(new StateA());
context.Request();
context.Request();
context.Request();