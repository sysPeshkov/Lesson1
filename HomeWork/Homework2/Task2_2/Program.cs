/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/
Console.Clear();
Console.WriteLine("Введите целое число ");

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed) {
    Console.WriteLine("Пожалуйста, введите целое число ");
    return;
}

int have3number = (number / 100);

if (have3number == 0){
    Console.WriteLine("третьей цифры нет ");
    return;
}
int lastNumber = number % 10;
Console.WriteLine (lastNumber);
