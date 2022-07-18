using Facade.Subsystems;

Facade.Facade facade = new(new SubsystemA(), new SubsystemB(), new SubsystemC());
facade.Operation();