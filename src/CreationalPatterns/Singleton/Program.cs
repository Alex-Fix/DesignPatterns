Singleton instance;

instance = Singleton.GetInstance();
Console.WriteLine(instance.RandomValue);

instance = Singleton.GetInstance();
Console.WriteLine(instance.RandomValue);