using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Успадкуванняя_основи
{
    abstract class Figure
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            circle1.CalculateArea();
            circle1.CalculatePerimeter();
         
            Rectangle rectangle1 = new Rectangle(6, 10);
            rectangle1.CalculateArea();
            rectangle1.CalculatePerimeter();
            Console.ReadLine();
        }

    }

    class Circle : Figure
    {
        double Radius;
        double Square;
        double Perimetr;
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double CalculateArea()
        {
            Square = Math.PI * Radius * Radius;
            Console.WriteLine($"Площа круга: {Square}");
            return Square;
        }
        public override double CalculatePerimeter()
        {
            Perimetr = 2 * Math.PI * Radius;
            Console.WriteLine($"Периметр круга: {Perimetr}");
            return Perimetr;
        }

    }

    class Rectangle : Figure
    {
        double Width;
        double Height;
        double SquareR;
        double PerimetrR;
        public Rectangle (double width,double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double CalculateArea()
        {
            SquareR = Width * Height;
            Console.WriteLine($"Площа прямокутника: {SquareR}");
            return SquareR;
        }
        public override double CalculatePerimeter()
        {
            PerimetrR = 2*Width + 2*Height;
            Console.WriteLine($"Периметр прямокутника: {PerimetrR}");
            return PerimetrR;
        }
    }
}*/