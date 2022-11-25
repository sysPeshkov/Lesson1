// See https://aka.ms/new-console-template for more information
/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

if (a > b) 
{
   Console.WriteLine("Число a больше b");
   Console.Write("a = ");
   Console.WriteLine(a);
}
else if (a < b) 
{
   Console.WriteLine("Число b больше a");
   Console.Write("b = ");
   Console.WriteLine(b);
}
else 
{
    Console.WriteLine("Число b равно a");
    Console.Write("b = ");
    Console.WriteLine(b);
}