using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;



namespace HW2.EX2

{
    class TriAngleFactory : ShapeInterface
    {
        Random rd = new Random();
        public Shape CreateShape()
        {
            Point a = new Point(rd.Next(1, 100), rd.Next(1, 100));
            Point b = new Point(rd.Next(1, 100), rd.Next(1, 100));
            Point c = new Point(rd.Next(1, 100), rd.Next(1, 100));
            return new TriAngle(a, b, c);
        }
    }



    class RectangleFactory : ShapeInterface
    {
        Random rd = new Random();
        public Shape CreateShape()
        {
            Point a = new Point(rd.Next(1, 100), rd.Next(1, 100));
            Point b = new Point(rd.Next(1, 100), a.Y);
            Point c = new Point(b.X, rd.Next(1, 100));
            Point d = new Point(a.X, c.Y);
            return new Rectangle(a, b, c, d);
        }
    }
    class SquareFactory : ShapeInterface
    {
        Random rd = new Random();
        public Shape CreateShape()
        {
            Point a = new Point(rd.Next(1, 100), rd.Next(1, 100));
            Point b = new Point(rd.Next(1, 100), a.Y);
            int length = Math.Abs(a.X - b.X);
            Point c = new Point(a.X, a.Y + length);
            Point d = new Point(b.X, b.Y + length);
            return new Square(a, b, c, d);
        }
    }



    class Factory
    {
        // randomly generate N shapes and sum the area.
        public double SumOfArea( int N)

        {
            Random rd = new Random();
            double sum = 0.0;
            ShapeInterface shapeInterface = new RectangleFactory();
            Shape shape = shapeInterface.CreateShape();

            // randomly generate N shapes
            for (int i = 0; i < N; i++)
            {
                int kind = rd.Next(1, 4);
                switch (kind)
                {
                    case 1:
                        shapeInterface = new TriAngleFactory();
                        break;
                    case 2:
                        shapeInterface = new RectangleFactory();
                        break;
                    case 3:
                        shapeInterface = new SquareFactory();
                        break;
                }
                shape = shapeInterface.CreateShape();
                sum += shape.GetArea();
            }
            return sum;
        }
    }
}