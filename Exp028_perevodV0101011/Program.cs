/* **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

int a;
Console.Write($"Введите число для перевода: ");
int.TryParse(Console.ReadLine()!, out a);

int b;
Console.Write($"Введите систему: ");
int.TryParse(Console.ReadLine()!, out b);

int temp = a;
string str = "";

while (temp > 0)
{
str = str.Insert(0, (temp % b).ToString());
temp /= b;
}

Console.Write(str);