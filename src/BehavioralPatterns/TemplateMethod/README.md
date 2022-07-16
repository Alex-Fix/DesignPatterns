# Template Method

> In object-oriented programming, the template method is one of the behavioral design patterns identified by Gamma in the book Design Patterns. The template method is a method in a superclass, usually an abstract superclass, and defines the skeleton of an operation in terms of a number of high-level steps. These steps are themselves implemented by additional helper methods in the same class as the template method.

## Use cases

* When it is planned that in the future subclasses will have to redefine various stages of the algorithm without changing its structure
* When there is code duplication in classes that implement a similar algorithm. Moving common code into a template method will reduce its duplication in subclasses