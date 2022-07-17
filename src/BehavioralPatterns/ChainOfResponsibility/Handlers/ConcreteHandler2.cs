namespace ChainOfResponsibility.Handlers;

internal class ConcreteHandler2 : Handler
{
      internal override void HanlderRequest(int condition)
      {
            // Request handling
            Console.WriteLine(nameof(ConcreteHandler2));

            if (condition == 2)
            {
                  // End of request handling
                  return;
            }

            Successor?.HanlderRequest(condition);
      }
}