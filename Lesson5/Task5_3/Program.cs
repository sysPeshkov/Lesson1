// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();
int min = InputNumber("Введите нижнюю границу ");
int max = InputNumber("Введите верхнюю границу ");
int size = InputNumber("Введите размер массива ");
int[] array = new int[size];
array = GenerateArray(min, max, size);
PrintArray(array);

int minLine = InputNumber("Введите нижнюю границу отрезка для поиска");
int maxLine = InputNumber("Введите верхнюю границу отрезка для поиска");

Console.WriteLine($"{CountNumberInLine(array, minLine, maxLine)} - количество элементов, входящих в отрезок от {minLine} до {maxLine}");


int CountNumberInLine(int[] array, int min, int max){
    int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= min && array[i] <= max){
        count += 1;
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