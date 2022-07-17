namespace ChainOfResponsibility.Handlers;

internal abstract class Handler
{
      internal Handler? Successor { get; set; }
      internal abstract void HanlderRequest(int condition);
}
