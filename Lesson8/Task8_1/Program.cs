// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

using static Major.Class1.Helper;
Console.Clear();

int m = InputNumber("Введите количество строк");
int n = InputNumber("Введите количество столбцов");

int[,] array = Fill2DArray(m, n);
Print2DArray(array);

int[,] revertArray = RevertFirstAndLastRows(array);
Console.WriteLine(" ");
Console.WriteLine("Ваш массив:");
Print2DArray(revertArray);

int[,] RevertFirstAndLastRows(int[,] array)
{
    int numberColumns = array.GetLength(1);
    int numberRows = array.GetLength(0);
    int[,] resultArray = new int[numberRows, numberColumns];
    int[] firstRow = new int[numberColumns];
    int[] lastRow = new int[numberColumns];
    int[] tmpRow = new int[numberColumns];

for (int i = 0; i < numberRows; i++)
{
   for (int j = 0; j < numberColumns; j++)
   {
    resultArray[i,j] = array[i,j];
   } 
}

    for (int i = 0; i < numberColumns; i++)
    {
       firstRow[i] = array[0, i];           //Записываем первую строку
       lastRow[i] = array[numberRows-1, i]; //Записываем последнюю строку
        //меняем местами
       resultArray[0, i] = lastRow[i];
       resultArray[numberRows-1, i] = firstRow[i];
    }

 PrintArrayInt(firstRow);
 PrintArrayInt(lastRow);


    return resultArray;

}