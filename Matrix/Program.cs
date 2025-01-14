﻿using MatrixLibrary;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.ForegroundColor = ConsoleColor.White;
int n, m;
Console.Write("Кількість рядків = ");
n = int.Parse(Console.ReadLine());
Console.Write("Кількість стовпців = ");
m = int.Parse(Console.ReadLine());
int[,] matrix = Matrix.GenerateMatrix(n, m);
Matrix.DisplayMatrix(matrix);
Console.WriteLine($"Кількість додатніх елементів = {Matrix.CountPositiveElements(matrix)}\n");
string maxElementOfRepeat = Matrix.MaxElementOfRepeat(matrix);
Console.WriteLine($"{maxElementOfRepeat}\n");
int countRowNotContainZeroElement = Matrix.CountRowNotСontainZeroElement(matrix);
Console.WriteLine($"Кількість рядків, що не містять жодного нульового елемента = {countRowNotContainZeroElement}\n");
int countColumnHaveZeroElement = Matrix.CountColumnHaveZeroElement(matrix);
Console.WriteLine($"Кількість стовпців, що містять хоча б один нульовий елемент = {countColumnHaveZeroElement}\n");
string rowIndexLongestSeriesOfIdenticalElement = Matrix.RowIndexLongestSeriesOfIdenticalElement(matrix);
Console.WriteLine($"{rowIndexLongestSeriesOfIdenticalElement}\n");
string productElementsNotHaveNegativeElements = Matrix.ProductElementsNotHaveNegativeElements(matrix);
Console.WriteLine(productElementsNotHaveNegativeElements);
int maxSumDiagonal = Matrix.MaxSumDiagonal(matrix);
Console.WriteLine($"Максимум серед сум елементів діагоналей, паралельних головній діагоналі матриці = {maxSumDiagonal}\n");
string sumColElementsNotHaveNegativeElements = Matrix.SumColElementsNotHaveNegativeElements(matrix);
Console.WriteLine(sumColElementsNotHaveNegativeElements);
int minAbsSumDiagonal = Matrix.MinAbsSumDiagonal(matrix);
Console.WriteLine($"\nМінімум серед сум модулів елементів діагоналей, паралельних побічній діагоналі матриці = {minAbsSumDiagonal}\n");
string sumColElementsHaveNegativeElements = Matrix.SumColElementsHaveNegativeElements(matrix);
Console.WriteLine(sumColElementsHaveNegativeElements);
Console.WriteLine("\nТраспонована матриця:\n");
Matrix.DisplayMatrix(Matrix.TransposedMatrix(matrix));