// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static Major.Class1.Helper;
Console.Clear();

int n = InputNumber("Введите N");
if (n <= 0) {
    Console.WriteLine("Введите положительное целое число больше нуля");
    n = 1;
}
 Console.WriteLine(" "); 
GetNumbersFromNToOne(n);

void GetNumbersFromNToOne(int n){

    if (n == 0)
    {
     return;
    }
 Console.Write($"{n} "); 
 GetNumbersFromNToOne(n-1);

}
