using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class MyMatrix
    {
        private double[,] matrix;
        double currentMin, currentMax;

        public MyMatrix() { }

        public int Rows
        {
            get { return matrix.GetLength(0); }
        }

        public int Columns
        { 
            get { return matrix.GetLength(1); } 
        }

        public MyMatrix(int rows, int columns, double min, double max)
        {
            matrix = new double[rows, columns];
            currentMin = min;
            currentMax = max;
            Fill(min, max);
        }

        public void Fill(double min, double max)
        {
            Random rand = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.NextDouble() * (max - min) + min;
                }
        }

        public void ChangeSize(int rows, int columns)
        {
            double[,] oldMatrix = (double[,])matrix.Clone();
            matrix = new double[rows, columns];
            Fill(currentMin, currentMax);
            

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < oldMatrix.GetLength(0) && j < oldMatrix.GetLength(1))
                        matrix[i, j] = oldMatrix[i, j];
                    else continue;
                }
        }

        public void ShowPartially(int startRow, int endRow, int startColumn, int endColumn)
        {
            if (startRow < 0 ||
                startRow > matrix.GetLength(0) - 1 ||
                startRow > endRow ||
                endRow < 0 ||
                endRow > matrix.GetLength(0) - 1 ||
                startColumn < 0 ||
                startColumn > matrix.GetLength(1) - 1 ||
                startColumn > endColumn ||
                endColumn < 0 ||
                endColumn > matrix.GetLength(1) - 1) throw new Exception("Bad indexes");
            else
            {
                for (int i = startRow; i <= endRow; i++)
                {
                    for (int j = startColumn; j <= endColumn; j++)
                        Console.Write(string.Format("{0:f2} ", matrix[i, j]));
                    Console.WriteLine();
                }
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
        }

        public double this[int x, int y]
        {
            set { matrix[x, y] = value; }
            get { return matrix[x, y]; }
        }



    }
}
