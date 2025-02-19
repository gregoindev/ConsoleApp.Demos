using ConsoleApp.Classes.Interfaces;

namespace ConsoleApp.Classes.Classes.ShapeDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        public Rectangle(double width, double length)
        {
            Length = length;
            Width = width;
        }
        public double Length { get; set; }
        public override double Area()
        {
            return Length * Width;
        }

        public double Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
