/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
Console.Clear();
Console.WriteLine("Введите номер дня недели ");

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed) {
    Console.WriteLine("Пожалуйста, введите целое число ");
    return;
}

if (number == 6 | number == 7){
    Console.WriteLine("Да ");
    return;
}
else {
    Console.WriteLine("Нет ");
    return;
}