/*
Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

 int a = new Random().Next(100,999);
int b = int.Parse(int.Parse(a.ToString().Remove(0, 1)).ToString().Remove(1, 1));
Console.WriteLine($"{a} -> {b}");

/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
*/
int c = new Random().Next(1, 100000);
if (c < 100)
Console.WriteLine($"Третьей цифры нет");
else
Console.WriteLine($"{c} -> {int.Parse(c.ToString().Substring(2, 1))}");

/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
*/
int week = new Random().Next(1, 8);
if (week >=6)
Console.WriteLine($"{week} - Выходной");
else
Console.WriteLine($"{week} - Рабочий день");