// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив: 1 47 2
// 5 92 3
// 8 42 4
// Сумма элементов главной диагонали: 1+9+2 = 12
using static Major.Class1.Helper;

int m = InputNumber("Введите количество строк");
int n = InputNumber("Введите количество столбцов");

int[,] array = Fill2DArray(m, n);
Console.WriteLine("Вы задали массив:");
Print2DArray(array);

int sum = GetSumDiagonalElement(array);
Console.WriteLine($"Результат задания: {sum}");

int GetSumDiagonalElement(int[,] array)
{
int sumDiagonalElement = 0;
 for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j){
                        sumDiagonalElement += array[i,j]; 
                    }
                }

            }
            return sumDiagonalElement;
}
