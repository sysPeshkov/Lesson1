// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите x");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
Console.WriteLine("Введите y");
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);


if (!isParsedX || !isParsedY || x == 0 || y == 0)
{
Console.WriteLine("Вы ввели некорректные параметры");

}