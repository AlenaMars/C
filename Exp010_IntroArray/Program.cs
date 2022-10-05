// Урок 2. Лекция. 05.10.2022 Массивы
int Max(int arg1, int arg2,int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//                0   1   2   3   4   5    6   7  8
int [] array = {133, 22, 14, 55, 45, 127, 66, 66, 5};
array[4] = 12; //Заменяет 45 - под индексом 4 на 12
Console.WriteLine(array[4]);


int max = Max(Max(array[0], array[1], array[2]), 
              Max(array[3], array[4], array[5]), 
              Max(array[6], array[7], array[8])); // Поиск макс из 9

Console.WriteLine();
Console.WriteLine(max);