namespace TemplateMethod;

internal abstract class AbstractClass
{
      internal abstract void Operation1();
      internal abstract void Operation2();

      internal void TemplateMethod()
      {
            Operation1();
            Operation2();
      }
}
