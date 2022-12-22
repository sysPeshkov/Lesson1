// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using static Major.Class1.Helper;
Console.Clear();


int[,] matrix = GetSpiralMatrix(4, 4);
Print2DArray(matrix);

int[,] GetSpiralMatrix(int rows, int columns)
{
    int[,] resultMatrix = new int[rows, columns];

    int maxCol = 3;
    int maxRow = 3;
    //Значение, которое будет присваиваться колонкам
    int value = 0;
    //Значение, которое будет присваиваться строкам
    int tempValue = 0;
    //Число, с помощью которого будем менять направление счетчика
    int kRow = -1;
    int kCol = -1;
    //Количество иттераций для наполнения
    int maxItteration = 3;
    //Значения максимальных индексов колонок при прохождении
    int[] arrayMaxCol = { 3, 0, 2, 0 };
    int[] startCol = { 0, 2, 1, 1 };
    int[] qC = {4, -1, 3, 0};
    int resultCo = 0;
    //Значения максимальных индексов строк при прохождении
    int[] arrayMaxRow = { 3, 1, 2, 2 };
    int[] startRo = { 0, 3, 1, 2 };
    int[] qR = {4, 0, 3, 3};
    int resultRo = 0;
    int startColumn = 0;
    int startRow = 0;
    //Проходим по строке
    for (int i = 0; i < 4; i++)
    {
        startRow = startRo[i]; //{0, 3, 1, 2};
        maxRow = arrayMaxRow[i]; //{3, 1, 1, 2};
        startColumn = startCol[i]; //{ 0, 3, 0, 2 };
        maxCol = arrayMaxCol[i]; //{ 3, 0, 0, 1 };

        kCol = kCol * (-1);//1, -1, 1, -1
        kRow = kRow * (-1);//1, -1, 1, -1
        resultCo = qC[i];
        resultRo = qR[i];
          Console.WriteLine($"Иттерация{i}");
       Console.WriteLine($"j = {startColumn}; j!={resultCo}; j=j+{kCol}");
       Console.WriteLine($"k = {startRow}; k != {resultRo}; k=k+{kRow}");
        //Проходим по колонке
        for (int j = startColumn; j != resultCo; j=j+kCol ) // j = 0; j <= 3; j = j + 1 || j = 3; j <= 0; j = j - 1 || j = 0; j <= 2; j = j + 1 || j = 2; j <= 1; j = j - 1
        {
            value = tempValue + 1;
            Console.WriteLine($"resultMatrix {startRow}, {j}, value = {value}");
            resultMatrix[startRow, j] = value;
            tempValue = value;
            //Как только доходим к крайнему столбцу, начинаем проходить по строкам
            if (j == maxCol)
            {
                for (int k = startRow; k != resultRo; k=k+kRow) //k =0; k <=3; k = k +1 || k =3; k <=1; k k -1 || k =1; k <=2; k k +1
                {
                    Console.WriteLine($"resultMatrix {k}, {maxCol}, value = {tempValue}");
                    resultMatrix[k, maxCol] = tempValue;
                    tempValue = tempValue + 1;
                    if (k==maxRow){
                        tempValue = tempValue - 1;
                    }
                }
            }
        
        }
 Console.WriteLine($"");
    }
    return resultMatrix;
}
