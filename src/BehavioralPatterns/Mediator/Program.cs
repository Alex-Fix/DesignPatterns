using Mediator.Collegues;
using Mediator.Mediators;

ManagerMediator mediator = new();

Collegue customer = new CustomerCollegue(mediator);
Collegue programmer = new ProgrammerCollegue(mediator);
Collegue tester = new TesterCollegue(mediator);

mediator.Customer = customer;
mediator.Programmer = programmer;
mediator.Tester = tester;

customer.Send("There is an order, it is necessary to make a program");
programmer.Send("The program is ready, it is necessary to test");
tester.Send("The program has been tested and is ready for sale");