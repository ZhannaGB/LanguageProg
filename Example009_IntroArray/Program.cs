/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}
// Индексы       0    1    2   3     4    5    6    7    8
int[] array = { 11 , 21 , 31 , 41 , 15 , 61 , 17 , 18 , 19 };
array[0] = 12; //Каким образом обратиться к массиву и записать значение
Console.WriteLine(array[4]); // Каким образом обратиться к массиву и 
получить значение
*/
/*Как использовать поиск максимума из девяти*/

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
// Функция Мах с большой буквы, а переменная мах с 
// маленькой буквы, переменную можно заменить на result

Console.WriteLine(max);
//Это задача по поиску максимума из девяти