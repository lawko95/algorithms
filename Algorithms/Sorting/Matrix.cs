using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class Matrix
    {
        private readonly double[,] data;

        public int nRows { get; }
        public int nCols { get; }

        public Matrix(int n) : this(n, n) { }

        public Matrix(int m, int n) : this(m, n, 0) { }

        public Matrix(int m, int n, double x)
        {
            if (m <= 0 || n <= 0)
            {
                throw new ArgumentException("A matrix needs at least 1 row and 1 column");
            }
            nRows = m;
            nCols = n;
            data = new double[m, n];
            Fill(x);
        }

        public Matrix(Matrix matrix) : this(matrix.data) { }

        public Matrix(double[,] data)
        {
            nRows = data.GetLength(0);
            nCols = data.GetLength(1);
            this.data = new double[nRows, nCols];
            Array.Copy(data, this.data, data.Length);
        }

        public void Fill(double x)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = x;
                }
            }
        }

        public void PrintMatrix()
        {
            Console.WriteLine("The matrix is:");
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine("|");
            }
        }

        public static void Add()
        {
            // Implement matrix addition
        }

        public static void Subtract()
        {
            // Implement matrix subtraction
        }

        public static void ScalarMultiple()
        {
            // Implement scalar multiplication
        }
        public static void Multiply()
        {
            // Implement matrix multiplication
        }

        public static void InnerProduct() { 
            // implement getting the inner product of two vectors
        }
        public static void OuterProduct() {
            // implement getting the outer product of two vectors
        }

        public override string ToString()
        {
            return base.ToString();
            // TODO new ToString method
        }
    }
}
