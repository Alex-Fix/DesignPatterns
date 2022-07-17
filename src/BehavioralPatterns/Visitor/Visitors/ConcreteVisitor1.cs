using Visitor.Elements;

namespace Visitor.Visitors;

internal class ConcreteVisitor1 : Visitor
{
      internal override void VisitElementA(ElementA elementA) => elementA.OperationA();
      internal override void VisitElementB(ElementB elementB) => elementB.OperationB();
}
