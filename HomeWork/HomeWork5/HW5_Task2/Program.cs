// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Clear();
Tests();
int min = InputNumber("Введите нижнюю границу ");
int max = InputNumber("Введите верхнюю границу ");
int size = InputNumber("Введите размер массива ");
int[] array = new int[size];
array = GenerateArray(min, max, size);
PrintArray(array);

int num = GetSumOfNumbersWithOddIndices(array);
Console.WriteLine($"Сумма чисел с нечетным индексом = {num}");


int GetSumOfNumbersWithOddIndices(int[] array){
int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        {
            result+=array[i];
        }
    }
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
//[3, 7, 23, 12] -> 19
void Tests() {
int[] input = {3, 7, 23, 12};
int expectedResult = 19;
 if (GetSumOfNumbersWithOddIndices(input) != expectedResult)
 { 
        Console.WriteLine($"Error. Expect = {expectedResult}, result =  {GetSumOfNumbersWithOddIndices(input)}");
      
 }
}