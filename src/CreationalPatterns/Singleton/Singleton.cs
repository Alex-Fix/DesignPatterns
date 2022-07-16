internal class Singleton
{
      private static Singleton _instance = null!;
      private static object _syncRoot = new();

      internal int RandomValue { get; set; } = new Random(Guid.NewGuid().ToByteArray().Sum(b => b)).Next();

      internal static Singleton GetInstance()
      {
            if (_instance is null)
            {
                  lock (_syncRoot)
                  {
                        _instance = new();
                  }
            }

            return _instance;
      }
}
