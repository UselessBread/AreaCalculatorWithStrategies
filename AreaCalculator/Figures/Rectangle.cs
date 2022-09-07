namespace AreaCalculator.Figures
{
    public class Rectangle : IFigure
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double[] GetSides()
        {
            return new double[] { Length, Width };
        }
    }
}