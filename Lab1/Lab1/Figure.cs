using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Figure
    {
        private string figureName;
        private Point[] points;

        public string FigureName { get => figureName; }

        public static double GetLengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.Xcord - B.Xcord), 2) + Math.Pow((A.Ycord - B.Ycord), 2));
        }

        public double GetPerimeter()
        {
            double sum = 0;

            for (int i = 0; i < points.Length; i++)
            {
                sum += GetLengthSide(points[i], points[(i + 1) % points.Length]);
            }

            return sum;
        }


        public Figure(string _figureName, params Point[] _points)
        {
            figureName = _figureName;
            points = new Point[_points.Length];
            points = (Point[])_points.Clone();

        }
    }
}
