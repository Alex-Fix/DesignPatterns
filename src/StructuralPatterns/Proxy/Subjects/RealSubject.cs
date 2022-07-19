namespace Proxy.Subjects;

internal class RealSubject : Subject
{
      internal override void Request() => Console.WriteLine(nameof(RealSubject));
}
