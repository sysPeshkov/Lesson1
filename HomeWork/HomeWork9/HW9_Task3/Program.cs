// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static Major.Class1.Helper;
Console.Clear();

int m = InputNumber("Введите M");
int n = InputNumber("Введите N");

if (n <= 0 || m <= 0)
{
    Console.WriteLine("Введите положительное целое число больше нуля");
    n = 2;
    m = 1;
}

Console.WriteLine(" ");

Console.WriteLine(GetAkerman(m, n));
int GetAkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return GetAkerman(n - 1, 1);
    else
        return GetAkerman(n - 1, GetAkerman(n, m - 1));
}
