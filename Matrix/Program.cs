﻿using MatrixLibrary;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

int n, m;
Console.Write("Кількість рядків = ");
n = int.Parse(Console.ReadLine());
Console.Write("Кількість стовпців = ");
m = int.Parse(Console.ReadLine());
int[,] matrix = Matrix.GenerateMatrix(n, m);
Matrix.DisplayMatrix(matrix);
Console.WriteLine($"Кількість додатніх елементів = {Matrix.CountPositiveElements(matrix)}");
string maxElementOfRepeat = Matrix.MaxElementOfRepeat(matrix);
Console.WriteLine(maxElementOfRepeat);
int countRowNotContainZeroElement = Matrix.CountRowNotСontainZeroElement(matrix);
Console.WriteLine($"Кількість рядків, що не містять жодного нульового елемента = {countRowNotContainZeroElement}");
int countColumnHaveZeroElement = Matrix.CountColumnHaveZeroElement(matrix);
Console.WriteLine($"Кількість стовпців, що містять хоча б один нульовий елемент = {countColumnHaveZeroElement}");