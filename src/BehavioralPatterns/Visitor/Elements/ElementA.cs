using V = Visitor.Visitors;

namespace Visitor.Elements;

internal class ElementA : Element
{
      internal override void Accept(V.Visitor visitor) => visitor.VisitElementA(this);

      internal void OperationA() => Console.WriteLine(nameof(ElementA));
}
