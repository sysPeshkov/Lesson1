// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. 
// Не использовать готовые методы Min и Max

// [3 7 22 2 78] -> 76


Console.Clear();
Tests();
int min = InputNumber("Введите нижнюю границу ");
int max = InputNumber("Введите верхнюю границу ");
int size = InputNumber("Введите размер массива ");
int[] array = new int[size];
array = GenerateArray(min, max, size);
PrintArray(array);

int num = GetDiffMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элментами массива = {num}");


int GetDiffMaxMin(int[] array){
int result = 0;
int min = array[1];
int max = array[array.Length-1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    result = max - min;
return result;
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
//[3 7 22 2 78] -> 76
void Tests() {
int[] input = {3, 7, 22, 2, 78};
int expectedResult = 76;
 if (GetDiffMaxMin(input) != expectedResult)
 { 
        Console.WriteLine($"Error. Expect = {expectedResult}, result =  {GetDiffMaxMin(input)}");
      
 }
}