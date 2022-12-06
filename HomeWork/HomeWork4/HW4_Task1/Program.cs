// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) 
// и метод который возводит число A в натуральную степень B.
//  Задание должно быть выполнено в методе. 
// В методе не должно быть вывода в консоль. Не использовать Math.Pow()
Console.Clear();
Tests();

int a = InputNumber("A");
int b = InputNumber("B");

int result = Exponentiation(a, b);
Console.WriteLine($"A в степени В = {result}");



int Exponentiation(int number, int power) {
    int result = number;
    if (power == 0){
        return 1;
    } else if (power == 1){
        return result;
    } else {
    for (int i = 2; i <= power; i++)
    {
    result = result*number;
    }
    return result;
    }
}

int InputNumber(string name){
    Console.WriteLine($"Введите число {name}");
    string number = Console.ReadLine();
    bool isParsed = int.TryParse(number, out int result);

    if (!isParsed) {
        Console.WriteLine($"Вы ввели некорректное число, ожидается целое число, вы ввели {number}");
        return -1;
    }
    return result;
}

void Tests(){
int[] numbers = {2, 3, 4, 5};
int[] powers = {2, 3, 4, 3};
int[] expectedResult = {4, 27, 256, 125};
int length = numbers.Length;
for (int i = 0; i < length; i++)
{
    if (Exponentiation(numbers[i], powers[i]) != expectedResult[i]) {
        Console.WriteLine($"Error. For number[{i}] = {numbers[i]} and powers[{i}] = {powers[i]}. Expect = {expectedResult[i]}, result =  {Exponentiation(numbers[i], powers[i])}");
      
    }
}
}