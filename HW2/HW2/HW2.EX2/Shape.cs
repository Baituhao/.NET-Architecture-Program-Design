

using System;

using System.Collections;

using System.Collections.Generic;

using System.Drawing;

using System.Text;



namespace HW2.EX2
{
    interface Shape
    {
        public bool IsLegal();
        public double GetArea();
        public void ShowPoints();
    }

    class Rectangle : Shape
    {
        public double GetDist(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
        public Point[] PointsList = new Point[4];
        public Rectangle() { }
        public Rectangle(Point a, Point b, Point c, Point d)
        {
            PointsList[0] = a;
            PointsList[1] = b;
            PointsList[2] = c;
            PointsList[3] = d;
        }
        public bool IsLegal()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (PointsList[i] == PointsList[j])
                        return false;
                }
            }
            // whether the distant to centerpoint is the same
            double centerX = PointsList[0].X + PointsList[1].X + PointsList[2].X + PointsList[3].X / 4.0;
            double centerY = PointsList[0].Y + PointsList[1].Y + PointsList[2].Y + PointsList[3].Y / 4.0;
            double length = GetDist(PointsList[0].X, PointsList[0].Y, centerX, centerY);
            foreach (var x in PointsList)
            {
                if (GetDist(x.X, x.Y, centerX, centerY) != length)
                    return false;
            }
            return true;
        }
        public double GetArea()
        {
            return GetDist(PointsList[0].X, PointsList[0].Y, PointsList[1].X, PointsList[1].Y)
                   * GetDist(PointsList[1].X, PointsList[1].Y, PointsList[2].X, PointsList[2].Y);
        }
        public void ShowPoints()
        {
            foreach (var x in PointsList)
            {
                Console.WriteLine("(" + ((Point)x).X + "," + ((Point)x).Y + ")");
            }
        }
    }


    class Square : Rectangle
    {
        public Square(Point a, Point b, Point c, Point d)
        {
            PointsList[0] = a;
            PointsList[1] = b;
            PointsList[2] = c;
            PointsList[3] = d;
        }

        public new bool IsLegal()
        {
            double length = GetDist(PointsList[0].X, PointsList[0].Y, PointsList[1].X, PointsList[1].Y);
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (GetDist(PointsList[i].X, PointsList[i].Y,
                            PointsList[j].X, PointsList[j].Y) != length)
                        return false;
                }
            }
            return true;
        }
    }


    class TriAngle : Shape
    {
        public Point[] PointsList = new Point[3];
        public TriAngle(Point a, Point b, Point c)
        {
            PointsList[0] = a;
            PointsList[1] = b;
            PointsList[2] = c;
        }
        public bool IsLegal()
        {
            // if points are overlayed
            if (PointsList[0] == PointsList[1] ||
                PointsList[0] == PointsList[2] ||
                PointsList[1] == PointsList[2])
                return false;
            // if they are on the same line
            if ((PointsList[2].Y - PointsList[1].Y) * (PointsList[1].X - PointsList[0].X)
                == (PointsList[1].Y - PointsList[0].Y) * (PointsList[2].X - PointsList[1].X))
                return false;
            return true;
        }
        public double GetArea()
        {
            double Length1 = Math.Sqrt(
                (PointsList[2].Y - PointsList[1].Y) * (PointsList[2].Y - PointsList[1].Y) +
                (PointsList[2].X - PointsList[1].X) * (PointsList[2].X - PointsList[1].X)
            );
            double Length2 = Math.Sqrt(
               (PointsList[2].Y - PointsList[0].Y) * (PointsList[2].Y - PointsList[0].Y) +
                (PointsList[2].X - PointsList[0].X) * (PointsList[2].X - PointsList[0].X)
            );
            double Length3 = Math.Sqrt(
                (PointsList[1].Y - PointsList[0].Y) * (PointsList[1].Y - PointsList[0].Y) +
                (PointsList[1].X - PointsList[0].X) * (PointsList[1].X - PointsList[0].X)
            );
            double HalfLength = (Length1 + Length2 + Length3) / 2;
            double area = Math.Sqrt(HalfLength *
                                    (HalfLength - Length1) *
                                    (HalfLength - Length2) *
                                    (HalfLength - Length3));
            return area;
        }
        public void ShowPoints()
        {
            foreach (var x in PointsList)
            {
                Console.WriteLine("(" + ((Point)x).X + "," + ((Point)x).Y + ")");
            }
        }
    }
}