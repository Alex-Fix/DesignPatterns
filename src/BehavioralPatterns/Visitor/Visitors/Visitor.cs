using Visitor.Elements;

namespace Visitor.Visitors;

internal abstract class Visitor
{
      internal abstract void VisitElementA(ElementA elementA);
      internal abstract void VisitElementB(ElementB elementB);
}
