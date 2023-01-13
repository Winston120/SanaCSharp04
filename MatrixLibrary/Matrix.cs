using System;
using System.Data;

namespace MatrixLibrary
{
    public class Matrix
    {
        public static int[,] GenerateMatrix (int rowCount, int colCount)
        {
            int[,] matrix = new int[rowCount, colCount];
            Random random = new Random();
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i,j] = random.Next(-9,9);
                }
            return matrix;
        }
        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{ matrix[i, j],3}");
                }
                Console.WriteLine();
            }
        }
    }
}