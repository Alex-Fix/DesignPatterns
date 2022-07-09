namespace Prototype.Figures;

internal class Rectangle : IFigure
{
      private readonly int _width;
      private readonly int _height;

      internal Rectangle(int width, int height)
      {
            _width = width;
            _height = height;
      }

      public string Info => $"Figure: {nameof(Rectangle)}, width: {_width}, height: {_height}";

      public IFigure Clone() => (IFigure)MemberwiseClone();
}
