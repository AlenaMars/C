// 
void FillArray(int[] collection) 
{
    int length = collection.Length;
    int index = 0;
    while (index < length) 
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PtintArray(int[] col) 
{
    int count = col.Length;
    int position = 0;
    while(position < count) 
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10];

FillArray(array); // Заполнил массив
PtintArray(array); // Расспечатал массив

Console.WriteLine();

int pos = IndexOf(array, 466);
Console.WriteLine(pos);
