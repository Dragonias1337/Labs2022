using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Rectangle
    {
        private double side1, side2;
        private double area;
        private double perimeter;

        public double Area { get => area; }
        public double Perimeter { get => perimeter; }

        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
            area = AreaCalculator();
            perimeter = PerimeterCalculator();

        }
    }
}
