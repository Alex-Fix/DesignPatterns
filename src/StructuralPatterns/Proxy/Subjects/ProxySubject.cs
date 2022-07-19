namespace Proxy.Subjects;

internal class ProxySubject : Subject
{
      private RealSubject? _realSubject;

      internal override void Request()
      {
            if (_realSubject is null)
            {
                  _realSubject = new RealSubject();
            }

            _realSubject.Request();
      }
}
