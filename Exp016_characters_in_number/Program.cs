/* **Задача 26:**
Напишите программу, которая принимает на вход число и выдаёт
количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Количество цифр в {a} = {Digits(a)}");

int Digits(int a)
{
int temp = a;
int dig = 0;
while (temp != 0)
{
temp /= 10;
dig++;
}
return dig;
}
// два варианта первым - деление  на 10, второй логарифм плюс 1
int Digits2(int a)
{
return (int)Math.Log10(a) + 1;
}
