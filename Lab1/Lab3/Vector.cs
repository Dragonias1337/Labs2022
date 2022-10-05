using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public struct Vector
    {
        private int x, y, z;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }

        private double GetLength()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }


        public static Vector operator +(Vector v1, Vector v2)
        {
            var result = new Vector();
            result.X = v1.X + v2.X;
            result.Y = v1.Y + v2.Y;
            result.Z = v1.Z + v2.Z;
            return result;
        }

        public static int operator *(Vector v1, Vector v2)//scalar
        {
            var result = 0;
            result = v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
            return result;
        }

        public static Vector operator *(Vector v1, int n1)
        {
            return new Vector() { X = v1.X * n1, Y = v1.Y * n1, Z = v1.Z * n1 };
        }
        public static bool operator <(Vector v1, Vector v2)
        {
            return v1.GetLength()<v2.GetLength();
        }

        public static bool operator >(Vector v1, Vector v2)
        {
            return v1.GetLength() > v2.GetLength();
        }

        public static bool operator <=(Vector v1, Vector v2)
        {
            return v1.GetLength() <= v2.GetLength();
        }

        public static bool operator >=(Vector v1, Vector v2)
        {
            return v1.GetLength() >= v2.GetLength();
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.GetLength() == v2.GetLength();
        }
        public static bool operator !=(Vector v1, Vector v2)
        {
            return v1.GetLength() != v2.GetLength();
        }


    }
}
