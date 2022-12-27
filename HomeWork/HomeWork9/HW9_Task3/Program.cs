// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static Major.Class1.Helper;
Console.Clear();

int rows = InputNumber("Введите количество строк");
int columns = InputNumber("Введите количество столбцов");
int high = InputNumber("Введите размерность 3-го измерения");
