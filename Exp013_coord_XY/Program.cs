/* Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причем х у не равны 0 и выдает номер четверти плоскости, 
в которой находится эта точка
*/

int x, y;
Console.Write($"Введите координату X: ");
int.TryParse(Console.ReadLine()!, out x); // берем строку переводим в число выводим в out
Console.Write($"Введите координату Y: ");
int.TryParse(Console.ReadLine()!, out y);
if (x > 0 && y > 0) Console.Write($"1 четверти");
if (x < 0 && y > 0) Console.Write($"2 четверти");
if (x < 0 && y < 0) Console.Write($"3 четверти");
if (x > 0 && y < 0) Console.Write($"4 четверти");


/*//Можем ввести проверку на корректно введеный код
//например
//дополним

int x, y;
Console.Write($"Введите координату X: ");
bool flag1 = int.TryParse(Console.ReadLine()!, out x); // берем строку переводим в число выводим в out
Console.Write($"Введите координату Y: ");
bool flag2 = int.TryParse(Console.ReadLine()!, out y);
if(!flag1 || !flag2) Console.Write($"Неверный код");
else
{
    if (x > 0 && y > 0) Console.Write($"1 четверти");
    if (x < 0 && y > 0) Console.Write($"2 четверти");
    if (x < 0 && y < 0) Console.Write($"3 четверти");
    if (x > 0 && y < 0) Console.Write($"4 четверти");
}

//bool хранит true false
// можно переписать задачу на 2 проверки

int x, y;
Console.Write($"Введите координату X: ");
int.TryParse(Console.ReadLine()!, out x); // берем строку переводим в число выводим в out
Console.Write($"Введите координату Y: ");
int.TryParse(Console.ReadLine()!, out y);

if (x > 0)
{
    if(y > 0) Console.Write($"1 четверти");
    else
    Console.Write($"4 четверти");
}
else
{
    if(y > 0) Console.Write($"2 четверти");
    else
    Console.Write($"3 четверти"); 
}
*/
