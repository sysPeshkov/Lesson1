// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз
//  2 встречается 1 раз 
//  8 встречается 1 раз 
//  9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


using static Major.Class1.Helper;
Console.Clear();

int m = InputNumber("Введите количество строк");
int n = InputNumber("Введите количество столбцов");

int[,] array = Fill2DArray(m, n);
Print2DArray(array);

void GetSequense(int[,] array)
{
    int countRows = array.GetLength(0);
    int countColumns = array.GetLength(1);
    int countUnicNumbers = 0;
    int tmp = 0;

    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumns; j++)
        {
           if (array[i,j] == tmp){
            
           }
        }
    }

}