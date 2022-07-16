using F = AbstractFactory.Factories;

F.AbstractFactory factory;
Client client;

factory = new F.ConcreteFactory1();
client = new Client(factory);
client.Run();

factory = new F.ConcreteFactory2();
client = new Client(factory);
client.Run();