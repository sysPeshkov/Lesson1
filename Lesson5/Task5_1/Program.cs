// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


Console.Clear();
Tests();

int a = InputNumber("Введите длину массива ");
int[] array = new int[a];
array = FillArray(a);

PrintArray(array);

int[] invertArray = new int[array.Length];
invertArray = InvertArray(array);
PrintArray(invertArray);


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

int[] InvertArray(int[] array){
   
    for (int i = 0; i < array.Length; i++)
    {
    //Console.Write($"Введите элемент массива {i+1}");
    array[i] = array[i]*-1;
    }
    return array;
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


// [-4, -8, 8, 2] -> [4, 8, -8, -2]
void Tests(){
int[] numbers = {-4, -8, 8, 2};
int[] expectedResult = {4, 8, -8, -2};
int length = numbers.Length;
int[] result = new int[numbers.Length];
result = InvertArray(numbers);
for (int i = 0; i < length; i++)
{
    if (result[i] != expectedResult[i]) {
        Console.WriteLine($"Error. For number[{i}] = {numbers[i]}. Expect = {expectedResult[i]}, result =  {result[i]}");
      
    }
}
}