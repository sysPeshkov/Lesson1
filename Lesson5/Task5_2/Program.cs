// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

int a = InputNumber("Введите длину массива ");
int[] array = new int[a];
array = FillArray(a);

PrintArray(array);

int searchNumber = InputNumber("Введите число, которое будете искать в массиве ");
FindNumberInArray(searchNumber, array);

void FindNumberInArray(int number, int[] array){
   bool finded = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) {
            finded = true;
            
            break;
        }
    }
    if (finded = false) {
    Console.WriteLine("Нет");
    }
    else {Console.WriteLine("Да");}
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


//[6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да
// void Tests(){
// int[] numbers = {-4, -8, 8, 2};
// int[] expectedResult = {4, 8, -8, -2};
// int length = numbers.Length;
// int[] result = new int[numbers.Length];
// result = InvertArray(numbers);
// for (int i = 0; i < length; i++)
// {
//     if (result[i] != expectedResult[i]) {
//         Console.WriteLine($"Error. For number[{i}] = {numbers[i]}. Expect = {expectedResult[i]}, result =  {result[i]}");
      
//     }
// }
// }