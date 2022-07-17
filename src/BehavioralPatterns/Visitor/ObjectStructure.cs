using Visitor.Elements;
using V = Visitor.Visitors;

namespace Visitor;

internal class ObjectStructure
{
      private readonly List<Element> _elements = new();

      internal void Add(Element element) => _elements.Add(element);

      internal void Remove(Element element) => _elements.Remove(element);

      internal void Accept(V.Visitor visitor)
      {
            foreach (Element element in _elements)
            {
                  element.Accept(visitor);
            }
      }
}
