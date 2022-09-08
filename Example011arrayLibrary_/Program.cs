/* Первый метод.
Перепишем этот код с использованием генератора случайных чисел и с
 ичпользованием методов.
*/

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
int[] arra = new int[10]; //Создай новый массив, в котором будет 10 элементов
/*Сначала мы определили массив из 10 элементов. Далее вызвали FillArray,
 который заполнил нам массив. Потом PrintArray нам его распечатал.*/

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //сначала 0 ставили
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index; // если не писать брейк, то 
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array, 444);
Console.WriteLine(pos);
