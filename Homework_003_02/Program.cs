/*
    Задача 21. Напишите программу, которая принимает на вход координаты 
    двух точек и находит расстояние между ними в 3D пространстве.
*/

Console.Clear();
int[] A = new int[3];
int[] B = new int[3];
Console.Write("Введите координаты X первой точки: ");
int.TryParse(Console.ReadLine()!, out A[0]);
Console.Write("Введите координаты Y первой точки: ");
int.TryParse(Console.ReadLine()!, out A[1]);
Console.Write("Введите координаты Z первой точки: ");
int.TryParse(Console.ReadLine()!, out A[2]);
Console.WriteLine();
Console.Write("Введите координаты X второй точки: ");
int.TryParse(Console.ReadLine()!, out B[0]);
Console.Write("Введите координаты Y второй точки: ");
int.TryParse(Console.ReadLine()!, out B[1]);
Console.Write("Введите координаты Z второй точки: ");
int.TryParse(Console.ReadLine()!, out B[2]);

Console.WriteLine();
//int[] A = new int[3] {3, 6, 8};
//int[] B = new int[3] {2, 1, -7};
int x = (int)Math.Pow(A[0] - B[0], 2);
int y = (int)Math.Pow(A[1] - B[1], 2);
int z = (int)Math.Pow(A[2] - B[2], 2);
double ans = Math.Sqrt(x + y + z);
ans = Math.Round(ans, 2);
Console.Write($"{ans}");
