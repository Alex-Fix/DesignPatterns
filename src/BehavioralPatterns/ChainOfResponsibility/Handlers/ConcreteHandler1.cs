namespace ChainOfResponsibility.Handlers;

internal class ConcreteHandler1 : Handler
{
      internal override void HanlderRequest(int condition)
      {
            // Request handling
            Console.WriteLine(nameof(ConcreteHandler1));

            if (condition == 1)
            {
                  // End of request handling
                  return;
            }

            Successor?.HanlderRequest(condition);
      }
}
