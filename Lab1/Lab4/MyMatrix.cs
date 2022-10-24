using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class MyMatrix
    {
        private double[,] matrix;

        public MyMatrix() { }

        public int Rows
        {
            get { return matrix.GetLength(0); }
        }

        public int Columns
            { get { return matrix.GetLength(1); } }

        public MyMatrix(int rows, int columns, double min, double max)
        {
            matrix = new double[rows, columns];
            Random rand = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.NextDouble() * (max - min) + min;
                }            
        }

        public void Show()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0:f2} ", matrix[i, j]));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public MyMatrix(int rows, int columns)
        {
            matrix = new double[rows, columns];
        }


        public static MyMatrix operator +(MyMatrix x, MyMatrix y)
        {
            if (x.Rows == y.Rows && y.Columns == x.Columns)
            {
                MyMatrix result = new MyMatrix(x.Rows, y.Columns);

                for (int i = 0; i < x.Rows; i++)
                    for (int j = 0; j < x.Columns; j++)
                    {
                        result[i, j] = x[i, j] + y[i, j];
                    }
                return result;
            }
            else throw new Exception("Матрицы нельзя сложить: разные размеры");

        }

        public static MyMatrix operator -(MyMatrix x, MyMatrix y)
        {
            //сделай сам
            return new MyMatrix();
        }

        public static MyMatrix operator *(MyMatrix x, MyMatrix y)
        {
            //сделай сам
            return new MyMatrix();
        }

        public static MyMatrix operator *(MyMatrix x, double y)
        {
            //сделай сам
            return new MyMatrix();
        }

        public static MyMatrix operator /(MyMatrix x, double y)
        {
            return new MyMatrix();
        }
        public double this[int x, int y]
        {
            set { matrix[x, y] = value; }
            get { return matrix[x, y]; }
        }

    }




}
