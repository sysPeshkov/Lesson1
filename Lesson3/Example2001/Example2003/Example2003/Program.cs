/*
Задача 21: Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

Формула - корень квадратный из (xb-xa)^2+(yb-ya)^2
*/

Console.WriteLine("Введите x1");
bool isParsedX1 = int.TryParse(Console.ReadLine(), out int x1);
Console.WriteLine("Введите y1");
bool isParsedY1 = int.TryParse(Console.ReadLine(), out int y1);

Console.WriteLine("Введите x2");
bool isParsedX2 = int.TryParse(Console.ReadLine(), out int x2);
Console.WriteLine("Введите y2");
bool isParsedY2 = int.TryParse(Console.ReadLine(), out int y2);

Console.WriteLine($"А({x1},{y1})");
Console.WriteLine($"B({x2},{y2})");

if (!isParsedX1 || !isParsedY1 || !isParsedY2 ||!isParsedX2)
{
Console.WriteLine("Вы ввели некорректные параметры");

}
double distance;

if (x1 == x2 && y1 == y2)
{
    distance = 0;
//return 0;
}

 distance = GetDistanceBetweenCoordinates(x1, y1, x2, y2);

Console.WriteLine($"Растояние между точками равно {distance}");

double GetDistanceBetweenCoordinates(int x1, int y1, int x2, int y2) {
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    return distance;
}
