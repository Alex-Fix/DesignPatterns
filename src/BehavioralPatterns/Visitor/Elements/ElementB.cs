using V = Visitor.Visitors;

namespace Visitor.Elements;

internal class ElementB : Element
{
      internal override void Accept(V.Visitor visitor) => visitor.VisitElementB(this);

      internal void OperationB() => Console.WriteLine(nameof(ElementB));
}
