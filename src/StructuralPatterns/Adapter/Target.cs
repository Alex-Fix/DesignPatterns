namespace Adapter;

internal class Target
{
      internal virtual void Request() => Console.WriteLine(nameof(Target));
}
