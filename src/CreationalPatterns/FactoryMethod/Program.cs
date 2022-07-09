using FactoryMethod.Creators;
using FactoryMethod.Products;

Developer developer;
House house;

developer = new WoodDeveloper("Alex Corporation");
house = developer.Create();
Console.WriteLine(house.Message);

developer = new PanelDeveloper("Fix Corporation");
house = developer.Create();
Console.WriteLine(house.Message);