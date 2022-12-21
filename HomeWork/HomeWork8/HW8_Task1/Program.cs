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

// int m = InputNumber("Введите количество строк");
// int n = InputNumber("Введите количество столбцов");
// int min = InputNumber("Введите минимальное значение");
// int max = InputNumber("Введите максимальное");

// int[,] array = Generate2DArray(m, n, min, max);
// Console.WriteLine("Вы задали массив:");
// Print2DArray(array);

int[] arr = { 8, 2, 5, 6, 2, 1 };
PrintArrayInt(SortNumberInArray(arr));

int[] SortNumberInArray(int[] array)
{

    int length = array.Length;
    int min = array[0];
    int tmp = 0;
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = array[i];
    }
    for (int i = 1; i < length - 1; i++)
    {
        if (resultArray[i] < min)
        {
            tmp = resultArray[i - 1];
            resultArray[i - 1] = resultArray[i];
            resultArray[i] = tmp;
        }
    }
    return resultArray;

}






