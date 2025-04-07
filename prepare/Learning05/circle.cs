public class Circle : Shape
{

    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

        public override double GetArea()
    {
        return 2 * 3.1415926535897932384 * _radius;
    }
}