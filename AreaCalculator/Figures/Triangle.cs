using System;

namespace AreaCalculator.Figures
{
    public class Triangle : IFigure
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }

        /// <summary>
        /// Создание треугольника
        /// </summary>
        /// <param name="firstSide"></param>
        /// <param name="secondSide"></param>
        /// <param name="thirdSide"></param>
        /// <exception cref="ArgumentException"></exception>
        /// <remarks>
        ///     Параметры должны быть >=0 и удовлетворять усолвию firstSide + secondSide > thirdSide || firstSide + thirdSide > secondSide ||
        ///     secondSide + thirdSide > firstSide
        /// </remarks>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("Sides must be greater or equals zero");

            if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide ||
                            secondSide + thirdSide <= firstSide)
                throw new ArgumentException("Triangle is not valid");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public bool IsRightAngled()
        {
            double squaredFirstSide = Math.Pow(FirstSide, 2);
            double squaredSecondSide = Math.Pow(SecondSide, 2);
            double squaredThirdSide = Math.Pow(ThirdSide, 2);
            if (squaredFirstSide == squaredSecondSide + squaredThirdSide ||
                squaredSecondSide == squaredFirstSide + squaredThirdSide ||
                squaredThirdSide == squaredFirstSide + squaredSecondSide)
                return true;

            return false;
        }

        public double[] GetSides()
        {
            return new double[] { FirstSide, SecondSide, ThirdSide };
        }
    }
}