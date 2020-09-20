using System;
using System.Security.Cryptography.X509Certificates;

namespace HW2.EX1
{
    interface Feasibility
    {
        bool isFeasible();
    }

    abstract class Polygon
    {
        public bool feasible;
        abstract public double area();
        abstract public void showSides();
    }

    class Triangle : Polygon,Feasibility
    {
        double a, b, c;
        
        public Triangle (double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (!isFeasible())
                Console.WriteLine("**********this triangle is not feasible*********");
        }
        public bool isFeasible()
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
                return false;
            return true;
        }
        public override double area()
        {
            if (!this.isFeasible())
                return -1;
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override void showSides()
        {
            Console.WriteLine($"Triangle: a={a},b={b},c={c}");
        }
    }

    class Rectangle : Polygon,Feasibility
    {
        double a, b;
        public Rectangle (double a, double b)
        {
            this.a = a;
            this.b = b;
            if (!isFeasible())
                Console.WriteLine("this rectangle is not feasible");
        }

        public bool isFeasible()
        {
            if (a <= 0 || b <= 0)
                return false;
            return true;
        }

        public override double area()
        {
            if (!isFeasible())
                return -1;
            return a * b;
        }
        public override void showSides()
        {
            Console.WriteLine($"Rectangle: a={a},b={b}");
        }
    }
    class Square : Polygon ,Feasibility
    {
        double a;
        public Square (double a)
        {
            this.a = a;
            if (!isFeasible())
                Console.WriteLine("this square is not feasible");
        }
        
        public bool isFeasible()
        {
            if (a <= 0)
                return false;
            return true;
        }
        public override double area()
        {
            if (!isFeasible())
                return -1;
            return a * a;
        }
        public override void showSides()
        {
            Console.WriteLine($"Square: a={a}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Triangle triangle1 = new Triangle(3, 4, 5);
            triangle1.showSides();
            Console.WriteLine($"area = {triangle1.area()}\n");

            Triangle triangle2 = new Triangle(1, 2, 4);
            triangle2.showSides();
            Console.WriteLine($"area = {triangle2.area()}\n");

            Rectangle rectangle = new Rectangle(2.4, 3.0);
            rectangle.showSides();
            Console.WriteLine($"area = {rectangle.area()}\n");

            Square square = new Square(3);
            square.showSides();
            Console.WriteLine($"area = {square.area()}\n");



        }
    }
}
