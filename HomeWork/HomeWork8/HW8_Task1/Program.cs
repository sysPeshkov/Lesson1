// Задача 54: Задайте двумерный массив.
//  Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


using static Major.Class1.Helper;
Console.Clear();

int m = InputNumber("Введите количество строк");
int n = InputNumber("Введите количество столбцов");
int min = InputNumber("Введите минимальное значение");
int max = InputNumber("Введите максимальное");

int[,] array = Generate2DArray(m, n, min, max);
Console.WriteLine("Вы задали массив:");
Print2DArray(array);

int[,] sortedArray = SortNumberIn2DArrayOnRows(array);
Console.WriteLine("Отсортированный массив:");
Print2DArray(sortedArray);


int[] SortNumberInArray(int[] array)
{

    int length = array.Length;
    int tmp = 0;
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = array[i];
    }
    //Сортировка
    //берем каждый элемент, начиная с первого до предпоследнего
    for (int i = 0; i < length - 1; i++)
    {
        //начиная со следующего после текущего начинаем проверять какой элемент больше
        for (int j = i + 1; j < length; j++)
        {
            if (resultArray[i] < resultArray[j])
            {
                tmp = resultArray[i];
                resultArray[i] = resultArray[j];
                resultArray[j] = tmp;
            }
        }
    }
    return resultArray;
}

int[,] SortNumberIn2DArrayOnRows(int[,] array)
{
    int[,] resultArray = Copy2DArray(array);
    int numberRows = array.GetLength(0);
    int numberColumns = array.GetLength(1);
    //Разбираем каждую строку на отдельный массив, чтобы по отдельности отсортировать
    int[] tepmArray = new int[resultArray.GetLength(1)];
    //Отсортированная строка
    int[] tepmSortedArray = new int[resultArray.GetLength(1)];

    for (int i = 0; i < numberRows; i++)
    {
        for (int j = 0; j < numberColumns; j++)
        {
            //Получаем строку в отдельном массиве
            tepmArray[j] = array[i, j];
            //Записываем отсортированную строку в массив
        }
                    //Сортируем получившийся массив
        tepmSortedArray = SortNumberInArray(tepmArray);
        for (int k = 0; k < numberColumns; k++)
        {
            //Записываем отсортированную строку в массив
             resultArray[i, k] = tepmSortedArray[k];
            
        }
       
        Console.WriteLine($"Строка {i}");
        PrintArrayInt(tepmArray);
        Console.WriteLine($"Отсортированная строка {i}");
        PrintArrayInt(tepmSortedArray);
        Console.WriteLine();

    }
    return resultArray;
}




