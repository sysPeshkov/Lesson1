/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите x1");
bool isParsedX1 = int.TryParse(Console.ReadLine(), out int x1);
Console.WriteLine("Введите y1");
bool isParsedY1 = int.TryParse(Console.ReadLine(), out int y1);
Console.WriteLine("Введите z1");
bool isParsedZ1 = int.TryParse(Console.ReadLine(), out int z1);

Console.WriteLine("Введите x2");
bool isParsedX2 = int.TryParse(Console.ReadLine(), out int x2);
Console.WriteLine("Введите y2");
bool isParsedY2 = int.TryParse(Console.ReadLine(), out int y2);
Console.WriteLine("Введите z2");
bool isParsedZ2 = int.TryParse(Console.ReadLine(), out int z2);

Console.WriteLine($"А({x1},{y1},{z1})");
Console.WriteLine($"B({x2},{y2},{z2})");

if (!isParsedX1 || !isParsedY1 || !isParsedY2 ||!isParsedX2 ||!isParsedZ1 ||!isParsedZ2)
{
Console.WriteLine("Вы ввели некорректные параметры");

}
double distance;

if (x1 == x2 && y1 == y2 && z1 == z2)
{
    distance = 0;
//return 0;
}

 distance = GetDistanceBetweenCoordinates(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Растояние между точками равно {distance}");

double GetDistanceBetweenCoordinates(int x1, int y1, int z1, int x2, int y2, int z2) {
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

    return distance;
}
