using Visitor;
using Visitor.Elements;
using Visitor.Visitors;

ObjectStructure structure = new();
structure.Add(new ElementA());
structure.Add(new ElementB());
structure.Accept(new ConcreteVisitor1());
structure.Accept(new ConcreteVisitor2());