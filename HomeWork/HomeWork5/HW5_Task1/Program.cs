// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Tests();
//int min = InputNumber("Введите нижнюю границу ");
int min = 100;
//int max = InputNumber("Введите верхнюю границу ");
int max = 1000;
int size = InputNumber("Введите размер массива ");
int[] array = new int[size];
array = GenerateArray(min, max, size);
PrintArray(array);

int num = GetCountOfEvenNumbers(array);
Console.WriteLine($"Количество четных чисел = {num}");


int GetCountOfEvenNumbers(int[] array){
int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count+=1;
        }
    }
return count;
}



int[] GenerateArray(int min, int max, int size){
    int[] resultArray = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(min, max+1);
    }
    return resultArray;

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

void PrintArray(int[] array){
    int length = array.Length;
    Console.Write("[ ");
for (int i = 0; i < length; i++)
{
    Console.Write($"{array[i]} ");
}
    Console.Write("]");
    Console.WriteLine("");
}

void Tests() {
int[] input = {345, 897, 568, 234};
int expectedResult = 2;
 if (GetCountOfEvenNumbers(input) != expectedResult)
 { 
        Console.WriteLine($"Error. Expect = {expectedResult}, result =  {GetCountOfEvenNumbers(input)}");
      
 }
}