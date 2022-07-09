namespace Prototype.Figures;

internal interface IFigure
{
      string Info { get; }
      IFigure Clone();
}
