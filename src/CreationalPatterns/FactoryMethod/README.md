# Factory Method

> In class-based programming, the factory method pattern is a creational pattern that uses factory methods to deal with the problem of creating objects without having to specify the exact class of the object that will be created. This is done by creating objects by calling a factory method—either specified in an interface and implemented by child classes, or implemented in a base class and optionally overridden by derived classes—rather than by calling a constructor.

## Use cases

* When it is not known in advance what types of objects need to be created
* When the system must be independent of the process of creating new objects and extensible: it can easily introduce new classes, the objects of which the system must create.
* When the creation of new objects must be delegated from the base class to descendant classes