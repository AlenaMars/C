
//Двумерный массив из строк
// string [,] table = new string[2, 5];  
// String.Empty - инициализация строк
// table[0,0]  table[0,1]  table[0,2]....
// table[1,0]  table[1,1]  table[1,2]....
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"- {table[rows,columns]} -");
//     }
// }
// Двумерный массив из чисел


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.WriteLine($"{matr[i, j]} ");
        }
        Console.WriteLine();    //Переход на новую строку для красивого отображения
    }
    
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // 1 10
        }
        
    }
}
                    //  строки столбцы
int[,] matrix = new int[3,4];
FillArray(matrix);
PrintArray(matrix);