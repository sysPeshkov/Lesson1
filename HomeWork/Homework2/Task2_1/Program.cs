/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
Console.Clear();
Console.WriteLine("Введите трёхзначное целое число ");

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed |  100 > number | number > 999) {
    Console.WriteLine("Пожалуйста, введите трёхзначное целое число ");
    return;
}

int result = (number / 10)%10;

Console.WriteLine (result);
