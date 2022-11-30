/*
Решение в группах задач:
Задача 18: Напишите программу, которая по заданному номеру
четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

Console.WriteLine("Введите номе четверти");
bool isParsedQuarterNumber = int.TryParse(Console.ReadLine(), out int quarterNumber);


string diapozon = GetQuarterNumberByCoordinates(quarterNumber);


Console.Write("Вам доступен диапозон - ");
Console.WriteLine(diapozon);


string GetQuarterNumberByCoordinates(int quarterNumber) {
    string a;
    if (quarterNumber == 1) {
        a = "x > 0 && y > 0";
        return a;
    }
        if (quarterNumber == 2) {
        a = "x < 0 && y > 0";
        return a;
    }
        if (quarterNumber == 3) {
        a = "x < 0 && y < 0"   ;
        return a;
    }
        if (quarterNumber == 4) {
            a = "x > 0 && y < 0";
        return a;
    }

    return "-1";
}