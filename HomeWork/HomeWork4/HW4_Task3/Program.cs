// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int a = InputNumber("Введите длину массива ");
int[] array = new int[a];
array = FillArray(a);
PrintArray(array);





void PrintArray(int[] array){
    int length = array.Length;
    Console.Write("[ ");
for (int i = 0; i < length; i++)
{
    Console.Write($"{array[i]}, ");
}
    Console.Write("]");
    Console.WriteLine("");
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

