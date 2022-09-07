using AreaCalculator.Figures;

namespace AreaCalculator.Strategies
{
    public interface IAreaStrategy
    {
        public double CalculateArea(IFigure figure);
    }
}