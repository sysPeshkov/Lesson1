// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N. 
//  Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using static Major.Class1.Helper;
Console.Clear();

int m = InputNumber("Введите M");
int n = InputNumber("Введите N. Число должно быть больше M");

if (n <= 0 || m <= 0) {
    Console.WriteLine("Введите положительное целое число больше нуля");
    n = 2;
    m = 1;
}
if (n <= m) {
    Console.WriteLine("N должно быть больше M");
    n = 2;
    m = 1;
}
 Console.WriteLine(" "); 

int sum = GetSumFromMToN(m, n);
Console.WriteLine(sum);

int GetSumFromMToN(int m, int n){
int sum = 0;
    if (m == n)
    {
     return 1;
    }

sum = n + GetSumFromMToN(m, n-1);

return sum;
}

