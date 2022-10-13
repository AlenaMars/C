//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int a;
Console.Write($"Введите число A: ");
int.TryParse(Console.ReadLine()!, out a);
int b;
Console.Write($"Введите число B: ");
int.TryParse(Console.ReadLine()!, out b);
for (int i = 1; i <= b; i++)
{
    int c = (int)Math.Pow(a, b);
    Console.Write($"{a} в степени {b} равно {c}");
    break;
}
