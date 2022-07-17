using ChainOfResponsibility.Handlers;

Handler handler1 = new ConcreteHandler1();
Handler handler2 = new ConcreteHandler2();

handler1.Successor = handler2;
handler1.HanlderRequest(2);