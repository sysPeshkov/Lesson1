// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив выглядел вот так:
// 1 47 2
// 5 9 3
// 8 42 4
// Новый массив будет выглядеть вот так:
// 1 47 2
// 5 81 9
// 8 42 4
using static Major.Class1.Helper;

int m = InputNumber("Введите количество строк");
int n = InputNumber("Введите количество столбцов");

int[,] array = Fill2DArray(m, n);
Console.WriteLine("Вы задали массив:");
Print2DArray(array);

int[,] arrayNew = GetKvadroForOddElement(array);
Console.WriteLine("Результат задания:");
Print2DArray(arrayNew);


int[,] GetKvadroForOddElement(int[,] array)
{
     int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
 for (int i = 0; i < resultArray.GetLength(0); i++)
            {
                for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    if (i%2 != 0 && j%2 != 0){
                        resultArray[i, j] = array[i,j] * array[i,j]; 
                    }
                    else{
                         resultArray[i, j] = array[i,j];
                    }
                }

            }
            return resultArray;
}