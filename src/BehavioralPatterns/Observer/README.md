# Observer

> The observer pattern is a software design pattern in which an object, named the subject, maintains a list of its dependents, called observers, and notifies them automatically of any state changes, usually by calling one of their methods.

## Use cases

* When the system consists of many classes whose objects must be in consistent states
* When the general scheme of interaction between objects involves two parties: one sends messages and is the main one, the other receives messages and reacts to them. Separating the logic of both sides allows them to be considered independently and used separately from each other
* When there is one object that sends messages and many subscribers that receive messages. At the same time, the exact number of subscribers is not known in advance and the program may change during the course of the program.