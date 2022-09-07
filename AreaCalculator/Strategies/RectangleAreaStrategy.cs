using AreaCalculator.Figures;

namespace AreaCalculator.Strategies
{
    public class RectangleAreaStrategy : IAreaStrategy
    {
        public double CalculateArea(IFigure figure)
        {
            double[] sides = figure.GetSides();
            return sides[0] * sides[1];
        }
    }
}