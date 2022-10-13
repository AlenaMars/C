/* Задача 18. Напишите программу, которая принимает на вход четверть и показывает диапозон возможных координат точек в этой четверти (x и y)
*/
int x;
Console.Write($"Введите номер четверти: ");
int.TryParse(Console.ReadLine()!, out x); // берем строку переводим в число выводим в out
switch (x)
{
    case 1: //case 5:
        Console.Write($"x > 0 y > 0");
        break;
    case 2:
        Console.Write($"x < 0 y > 0");
        break;
    case 3:
        Console.Write($"x < 0 y < 0");
        break;
    case 4:
        Console.Write($"x > 0 y < 0");
        break;
    default:
        Console.Write($"Не верный ввод"); // во всех остальных случаях
        break;
}
