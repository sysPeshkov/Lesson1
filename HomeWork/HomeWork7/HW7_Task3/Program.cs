// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static Major.Class1.Helper;
Console.Clear();

int m = InputNumber("Введите количество строк");
int n = InputNumber("Введите количество столбцов");

int[,] array = Fill2DArray(m, n);
Console.WriteLine("Ваш массив:");
Print2DArray(array);

Console.WriteLine("Массив средних арифметических каждого столбца:");
double[] averageArray = GetAverageInColumns(array);
PrintArray(averageArray);

