# Chain Of Responsibility

> In object-oriented design, the chain-of-responsibility pattern is a behavioral design pattern consisting of a source of command objects and a series of processing objects. Each processing object contains logic that defines the types of command objects that it can handle; the rest are passed to the next processing object in the chain. A mechanism also exists for adding new processing objects to the end of this chain.

## Use cases

* When there is more than one object that can handle a particular request
* When it is necessary to transfer a request for execution to one of several objects, without specifying exactly which object
* When a set of objects is set dynamically