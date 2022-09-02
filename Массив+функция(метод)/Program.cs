int [] array = {91,20,39,45,0,18,61,7,18};
int n = array.Length;  // определяет количество элементов массива

int find = 18;

int index = 0;

while (index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
