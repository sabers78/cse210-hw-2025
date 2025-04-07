using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();

        Square shapeOne = new Square("Blue", 3);
        Rectangle shapeTwo = new Rectangle("Yellow", 4,6);
        Circle shapeThree = new Circle("Green", 23);

        shapeList.Add(shapeOne);
        shapeList.Add(shapeTwo);
        shapeList.Add(shapeThree);

        foreach (Shape _shape in shapeList)
        {
            string color = _shape.GetColor();
            double area = _shape.GetArea();

            Console.WriteLine($"There is a {color} shape with an area of {area}");
        }
       
    }
}