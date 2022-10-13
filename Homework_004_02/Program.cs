// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
int d = Digits(a);
Console.WriteLine($"Сумма цифр в числе {a} = {Sum(a)}");
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

int Sum(int a)
{
    int s = 0;
    for (int i = 0; i <= d; i++)
    {
        int temp = a;
        s = s + temp % 10;
        a = a / 10;
    }
    return s;
}