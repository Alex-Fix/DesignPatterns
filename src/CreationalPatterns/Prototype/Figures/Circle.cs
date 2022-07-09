namespace Prototype.Figures;

internal class Circle : IFigure
{
      private readonly int _radius;

      internal Circle(int radius)
      {
            _radius = radius;
      }

      public string Info => $"Figure: {nameof(Circle)}, radius: {_radius}";

      public IFigure Clone() => (IFigure)MemberwiseClone();
}
