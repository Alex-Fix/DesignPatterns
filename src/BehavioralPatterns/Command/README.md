# Command

> In object-oriented programming, the command pattern is a behavioral design pattern in which an object is used to encapsulate all information needed to perform an action or trigger an event at a later time. This information includes the method name, the object that owns the method and values for the method parameters.

## Use cases

* When it is necessary to pass as parameters certain actions that are called in response to other actions. That is, when callback functions are needed in response to certain actions
* When it is necessary to ensure the execution of the request queue, as well as their possible cancellation
* When it is necessary to support logging of changes as a result of requests. Using logs can help restore the state of the system - for this you will need to use a sequence of logged commands