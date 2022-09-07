using AreaCalculator.Figures;
using System;

namespace AreaCalculator.Strategies
{
    public class TriangleAreaStrategy : IAreaStrategy
    {
        public double CalculateArea(IFigure figure)
        {
            double[] sides = figure.GetSides();
            double firstSide = sides[0];
            double secondSide = sides[1];
            double thirdSide = sides[2];
            double perimeter = (firstSide + secondSide + thirdSide) / 2;

            return Math.Sqrt(perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide));
        }
    }
}