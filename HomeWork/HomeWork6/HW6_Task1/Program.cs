// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();
Tests();

int a = InputNumber("Введите длину массива ");
int[] array = new int[a];
array = FillArray(a);
PrintArray(array);

int result = GetCountNumberMoreZero(array);
Console.WriteLine($"Количество чисел больше 0 равно {result}");


int GetCountNumberMoreZero(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i]>0){
        count += 1;
        }
    }
   
    return count;

}

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
//0, 7, 8, -2, -2 -> 2
void Tests() {
int[] input = {0, 7, 8, -2, -2};
int expectedResult = 2;
 if (GetCountNumberMoreZero(input) != expectedResult)
 { 
        Console.WriteLine($"Error. Expect = {expectedResult}, result =  {GetCountNumberMoreZero(input)}");
      
 }
}