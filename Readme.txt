Курс работ по языку программирования С#
Лекция 3 - Продолжение работы с функциями
Вид 1.
void methods() // Ничего не принимает
{
Тело метода (например авторство)
}
Methods(); // Вызов функции

Вид 2. Принимает, не возвращает
Вариант 1.
void methods(string arg) // Принимает аргументы string - тип данных arg аргумент
{
Console.WriteLine(arg);
}
methods("Текст сообщения");
Вариант 2.
void methods(string msg, int count)
{
   int i=0;
   while(i<count)
       {
       Console.WriteLine(msg);
       i++;
       }
}
methods(count: 4, msg: "Новый текст");
Вид 3 Не принимает, возвращает

int Method3()
{
    return DateTime.Now.Year:
}
int year = Method3();
Console.WriteLine (year);

Вид 4 Принимает и возвращает
string Method4(count, text)
{
    i = 0;
    string result = String.Empty;
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Methos4 (4, "z");
Console.WriteLine (res);
