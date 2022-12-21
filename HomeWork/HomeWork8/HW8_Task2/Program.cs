// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
//  наименьшей суммой элементов: 1 строка

using static Major.Class1.Helper;
Console.Clear();
//Создаем 2х мерный массив
int m = InputNumber("Введите количество строк");
int n = InputNumber("Введите количество столбцов");
int min = InputNumber("Введите минимальное значение");
int max = InputNumber("Введите максимальное");
int[,] array = Generate2DArray(m, n, min, max);
Console.WriteLine("Вы задали массив:");
Print2DArray(array);

//Создаем 1 мерный массив, который хранит сумму и индекс
int[] sumElementsInRows = SumElementsOfRowIn2DArray(array);
Console.WriteLine("Суммы эелентов в строках массива: ");
PrintArrayInt(sumElementsInRows);

//Вытаскиваем максимальную сумму с индексом
MaxNumberAndIndexInArray(sumElementsInRows, out int maxVaue, out int maxIndexVaue);
Console.WriteLine();
Console.WriteLine($"Максимальная сумма = {maxVaue}");
Console.WriteLine($"{maxIndexVaue + 1} строка");

//Метод сложения всех элементов массива
int SumElementsInArray(int[] array)
{
    int length = array.Length;
    int sum = array[0];
    //Складываем все элементы массива
    for (int i = 1; i < length; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] SumElementsOfRowIn2DArray(int[,] array)
{
    int[,] resultArray = Copy2DArray(array);
    int numberRows = array.GetLength(0);
    int numberColumns = array.GetLength(1);
    //Здесь сохраним суммы всех строк
    int[] tepmSumElementsArray = new int[resultArray.GetLength(0)];
    //Здесь будем складывать элементы сроки
    int[] tepmArray = new int[resultArray.GetLength(1)];
    for (int i = 0; i < numberRows; i++)
    {
        for (int j = 0; j < numberColumns; j++)
        {
            //Вытаскиваем строку в отдельный массив
            tepmArray[j] = array[i, j];
            //Сортируем получившийся массив
        }
        //Записываем сумму элементов в массив
        tepmSumElementsArray[i] = SumElementsInArray(tepmArray);
    }
    //Возвращаем массив сумм элементов, индекс соответствует номер строки - 1
    return tepmSumElementsArray;
}
