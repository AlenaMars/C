// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
Console.WriteLine($">>>Задача 2 определяет какое число большее, какое меньшее");
Console.Write($"Введите 1 число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"Введите 2 число: ");
int b = int.Parse(Console.ReadLine()!);
if(a > b)
{
    Console.WriteLine($"Число {a} больше числа {b}");
}
else
{
    Console.WriteLine($"Число {b} больше числа {a}");
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine($">>>Задача 4 выдает максимальное из трех чисел");
Console.Write($"Введите 1 число: ");
int c = int.Parse(Console.ReadLine()!);
Console.Write($"Введите 2 число: ");
int d = int.Parse(Console.ReadLine()!);
Console.Write($"Введите 3 число: ");
int e = int.Parse(Console.ReadLine()!);
int max = c;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;
Console.WriteLine($"Число {max} является максимальным");

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine($">>>Задача 6 определяет чётное ли число");
Console.Write($"Введите число: ");
int ch = int.Parse(Console.ReadLine()!);
if(ch % 2 == 0)
{
    Console.WriteLine($"Число {ch} чётное");
}
else
{
    Console.WriteLine($"Число {ch} нечётное");
}

//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine($">>>Задача 8 показывает все чётные числа от 1 до N");
Console.Write($"Введите число: ");
int m = int.Parse(Console.ReadLine()!);

int i = 1;
while (i <= m)
{
    if (i % 2 == 0)
    Console.Write($"{i} ");
    i++;
}