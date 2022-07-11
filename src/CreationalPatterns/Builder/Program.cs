using Builder.Builders;
using Builder.Ingredients;

BreadBuilder breadBuilder;
Bread bread;

var baker = new Baker();

breadBuilder = new WheatBreadBuilder();
bread = baker.Bake(breadBuilder);
Console.WriteLine(bread);

breadBuilder = new RyeBreadBuilder();
bread = baker.Bake(breadBuilder);
Console.WriteLine(bread);