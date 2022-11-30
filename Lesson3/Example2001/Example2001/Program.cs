// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите x");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
Console.WriteLine("Введите y");
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);


if (!isParsedX || !isParsedY || x == 0 || y == 0)
{
Console.WriteLine("Вы ввели некорректные параметры");

}

int quarterNumber = GetQuarterNumberByCoordinates(x, y);

if (quarterNumber == -1) {
    Console.WriteLine("Вы ввели некорректные параметры");
    return;
}

Console.Write("Четверть номер ");
Console.WriteLine(quarterNumber);

int GetQuarterNumberByCoordinates(int x, int y) {
    if (x > 0 && y > 0) {
        return 1;
    }
        if (x < 0 && y > 0) {
        return 2;
    }
        if (x < 0 && y < 0) {
        return 3;
    }
        if (x > 0 && y < 0) {
        return 4;
    }

    return -1;
}