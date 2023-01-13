using MatrixLibrary;
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