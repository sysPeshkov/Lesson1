// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();

int a = InputNumber("Введите длину массива ");
int[] array = new int[a];
array = FillArray(a);

PrintArray(array);
int[] arrayResult = new int[a/2];
arrayResult = Multiplication(array, a/2);
PrintArray(arrayResult);

int[] Multiplication(int[] array, int size){
    int[] result = new int[size];
    int min = 0;
    int max = array.Length-1;
    while (min < max)
    {
        result[min] = array[min] * array[max];
        min += 1;
        max -= 1;
    }
    return result;
}



int[] FillArray(int length){
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
    //Console.Write($"Введите элемент массива {i+1}");
    resultArray[i] = InputNumber($"Введите элемент массива {i+1}");
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