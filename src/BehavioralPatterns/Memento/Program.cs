using M = Memento;

M.Originator originator = new();
originator.State = "Alex State";

M.Memento memento = originator.CreateMemento();
memento.State = "Alex New State";

originator.SetMemento(memento);
Console.WriteLine(originator.State);