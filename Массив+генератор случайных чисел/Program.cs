﻿void FillArray(int[] collection) // метод 1
{
int Length = collection.Length;
int index = 0;
while (index<Length)
{
collection[index] = new Random().Next(1, 10);
index++;
}
}

void PrintArray(int[] col)  // метод 2
{
    int count = col.Length;
    int position = 0;
    while (position<count)
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
    while(index<count)
    {
        if(collection[index]==find)
        {
        position = index;
        break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10]; //"создай массив из 10 элементов"

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);

// Заполенение и вывод массива
