// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

using static Major.Class1.Helper;
Console.Clear();

int m = InputNumber("Введите количество строк");
int n = InputNumber("Введите количество столбцов");

int[,] array = Fill2DArray(m, n);
Print2DArray(array);

int[,] revertArray = RevertColumnsAndRows(array);
Console.WriteLine(" ");
Console.WriteLine("Ваш массив:");
Print2DArray(revertArray);

int[,] RevertColumnsAndRows(int[,] array)
{
    int numberColumns = array.GetLength(1);
    int numberRows = array.GetLength(0);
    int[,] tmpArray = new int[numberRows, numberColumns];
    int[,] resultArray = new int[numberColumns, numberRows];

        for (int i = 0; i < numberRows; i++)
    {
        for (int j = 0; j < numberColumns; j++)
        {
            resultArray[j, i] = array[i, j];
        }
    }

    return resultArray;

}