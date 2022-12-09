// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 
//   значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.Clear();

Console.WriteLine("y = k1 * x + b1");
int b1 = InputNumber("Введите b1");
int k1 = InputNumber("Введите k1 ");


Console.WriteLine("y = k2 * x + b2");
int b2 = InputNumber("Введите b2");
int k2 = InputNumber("Введите k2 ");

GetIntersectionPoint(b1, k1, b2, k2);

void GetIntersectionPoint (int b1, int k1, int b2, int k2){
     
//    k1 * x + b1 = k2 * x + b2
//y
//    x (k1 - k2) = b2-b1
//    x = (b2-b1)/(k1-k2)
double b = b2-b1;
double k = k1-k2;
    double ResultX = b/k;
    double ResultY = k1*ResultX + b1;

Console.WriteLine($"Координаты точки пересечения ({ResultX}, {ResultY})");

}

int InputNumber(string name){
    Console.WriteLine(name);
    string number = Console.ReadLine();
    bool isParsed = int.TryParse(number, out int result);

    if (!isParsed) {
        Console.WriteLine($"Вы ввели некорректное число, ожидается целое число, вы ввели {number}");
        return -1;
    }
    return result;
}


