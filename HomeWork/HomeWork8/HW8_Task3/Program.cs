// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static Major.Class1.Helper;
Console.Clear();
//Создаем Матрицу 1
int m = InputNumber("Матрица 1. Введите количество строк");
int n = InputNumber("Матрица 1.Введите количество столбцов");
int minMatrix1 = InputNumber("Матрица 1.Введите минимальное значение");
int maxMatrix1 = InputNumber("Матрица 1.Введите максимальное");
int[,] matrix1 = Generate2DArray(m, n, minMatrix1, maxMatrix1);
Console.WriteLine("Вы задали Матрица 1:");
Print2DArray(matrix1);

//Создаем Матрицу 2
int minMatrix2 = InputNumber("Матрица 2.Введите минимальное значение");
int maxMatrix2 = InputNumber("Матрица 2.Введите максимальное");
int[,] matrix2 = Generate2DArray(n, m, minMatrix2, maxMatrix2);
Console.WriteLine("Вы задали Матрица 2:");
Print2DArray(matrix2);

int[,] matrix3 = GetResultMatrix(matrix1, matrix2);
Console.WriteLine("Результат произведения матриц:");
Print2DArray(matrix3);


int[,] GetResultMatrix(int[,] a, int[,] b)
{
    int countRowsMatrix1 = a.GetLength(0);
    int countColumnsMatrix2 = a.GetLength(0);
    int[,] resultArray = new int[countRowsMatrix1, countColumnsMatrix2];
    //Количество столбцов в матрице 1
    int n = a.GetLength(1);
    int value = 0;
    for (int i = 0; i < countRowsMatrix1; i++)
    {
        for (int j = 0; j < countColumnsMatrix2; j++)
        {
            for (int k = 0; k < n; k++)
            {
                value = value + a[i, k] * b[k, j];
            }
            Console.WriteLine(value);
            resultArray[i, j] = value;
            value = 0;
        }
    }

    return resultArray;
}