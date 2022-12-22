// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static Major.Class1.Helper;
Console.Clear();
//Создаем Матрицу 1
int rows = InputNumber("Введите количество строк");
int columns = InputNumber("Введите количество столбцов");
int high = InputNumber("Введите размерность 3-го измерения");

//Минимальная разница между максимумом и минимумом рандома
int diff = rows * columns * high;

int min = InputNumber("Введите минимальное значение");
int max = InputNumber($"Введите максимальное значение. Минимум {min + diff}");
if (max - min < diff)
{
    Console.WriteLine($"Минимальная разница между минимальным числом и максимальным должна быть равна {diff}, у вас {max - min}.");
    Console.WriteLine($"Не получится сгенерировать матрицу с уникальными элементами. Поэтому присвоили максимум {max = min + diff}");
    max = min + diff;
}

int[,,] matrix = GenerateRandomMatrixUnicElements(rows, columns, high, min, max);
Print3DMatrix(matrix);


int[,,] GenerateRandomMatrixUnicElements(int rows, int columns, int high, int min, int max)
{
    int[,,] resultMatrix = new int[rows, columns, high];
    Random random = new Random();
    int value = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < high; k++)
            {
                value = random.Next(min, max);

                while (FindNumberIn3DArray(value, resultMatrix) == true)
                {
                    value = random.Next(min, max);
                }
                resultMatrix[i, j, k] = value;
            }
        }
    }

    return resultMatrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < high; k++)
            {
                Console.WriteLine($"({i},{j},{k}) {matrix[i, j, k]}");
            }
        }
    }

}
