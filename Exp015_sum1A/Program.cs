/* Напишите функцию, которая принимает на вход число (А) и
выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Сумма цифр от 1 до {a} = {Sum(a)}");

int Sum(int a)
{
int sum = 0;
for (int i = 1; i <= a; i++)
sum += i;
return sum;
}