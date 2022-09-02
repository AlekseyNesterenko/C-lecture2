void FillArray(int[] collection) // метод 1
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
int [] array = new int[10]; //"создай массив из 10 элементов"

FillArray(array);
PrintArray(array);

// Заполенение и вывод массива
