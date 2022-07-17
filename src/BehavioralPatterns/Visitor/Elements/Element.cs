using V = Visitor.Visitors;

namespace Visitor.Elements;

internal abstract class Element
{
      internal string? SomeState { get; set; }
      internal abstract void Accept(V.Visitor visitor);
}
