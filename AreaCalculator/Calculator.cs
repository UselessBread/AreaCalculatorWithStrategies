using AreaCalculator.Factories;
using AreaCalculator.Figures;
using System;

namespace AreaCalculator
{
    public class Calculator
    {
        public double GetArea(IFigure figure, Type figureType)
        {
            AreaStrategyFactory factory = new AreaStrategyFactory();
            double area = factory.GetStrategy(figureType).CalculateArea(figure);

            return area;
        }
    }
}