// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static Major.Class1.Helper;
Console.Clear();

int m = InputNumber("Введите количество строк");
int n = InputNumber("Введите количество столбцов");

int[,] array = Fill2DArray(m, n);
Print2DArray(array);

int number = InputNumber("Введите число, которое будете искать в массиве");
FindNumberInArray(array, number);
