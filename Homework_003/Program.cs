

/*
    Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/
Console.Clear();
Console.Write("Введите пятизначное число: ");
string a = Console.ReadLine()!;
int length = a.Length;
    for (int i = 0; i < length/2; i++)
    {
        if(a[i] != a[length-1-i])
        {
            Console.Write("Не палиндром");
        }  
       else Console.Write("Палиндром");
       break;
    }
    


