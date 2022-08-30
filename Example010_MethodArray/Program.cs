/*
int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int n = array.Length;
int find = 18; //искомое число в массиве, 
//на выходе получаем номер индекса
//Если несколько одинаковых элементов этот массив покажет их все


int index = 0;

while (index < n)
{
if(array[index] == find)
{
    Console.WriteLine(index);
}
    index++;
}
*/
int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int n = array.Length;
int find = 18; //искомое число в массиве, 
//на выходе получаем номер индекса
//Если несколько одинаковых элементов этот массив покажет их все


int index = 0;

while (index < n)
{
if(array[index] == find)
{
    Console.WriteLine(index);
    break; //Прерви. Если аррай индекс совпал с файнд, прерви.

}
    index++;
}