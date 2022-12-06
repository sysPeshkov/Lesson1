// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Tests();

string a = InputNumber("A");

int result = SumNumbers(a);

Console.WriteLine($"Сумма чисел в А = {result}");

int SumNumbers(string number){
    int a = int.Parse(number);
    int[] array = new int[number.Length];
    for (int i = 0; i < number.Length; i++) {
    array[i] = a%10;
    a = a/10;
    }

    int result = 0;
    for (int i = 0; i < array.Length; i++) {
    result = result + array[i];
    }
//Console.WriteLine(array);
return result;
}

string InputNumber(string name){
    Console.WriteLine($"Введите число {name}");
    string number = Console.ReadLine();
    bool isParsed = int.TryParse(number, out int result);

    if (!isParsed) {
        Console.WriteLine($"Вы ввели некорректное число, ожидается целое число, вы ввели {number}");
        return "-1";
    }
    return number;
}


void Tests(){
int[] numbers = {452, 82, 9012};
int[] expectedResult = {11, 10, 12};
int length = numbers.Length;
for (int i = 0; i < length; i++)
{
    if (SumNumbers($"{numbers[i]}") != expectedResult[i]) {
        Console.WriteLine($"Error. For number[{i}] = {numbers[i]}. Expect = {expectedResult[i]}, result =  {SumNumbers($"{numbers[i]}")}");
      
    }
}
}