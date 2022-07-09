internal class Singleton
{
      private static Singleton _instance = null!;
      private static object _syncRoot = new object();

      internal int RandomValue { get; set; } = new Random(Guid.NewGuid().ToByteArray().Sum(b => (int)b)).Next();

      internal static Singleton GetInstance()
      {
            if (_instance is null)
            {
                  lock (_syncRoot)
                  {
                        _instance = new Singleton();
                  }
            }

            return _instance;
      }
}
