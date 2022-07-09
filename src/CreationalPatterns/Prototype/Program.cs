using Prototype.Figures;

IFigure figure;

figure = new Circle(121);
Console.WriteLine(figure.Info);
figure = figure.Clone();
Console.WriteLine(figure.Info);

figure = new Rectangle(29, 111);
Console.WriteLine(figure.Info);
figure = figure.Clone();
Console.WriteLine(figure.Info);