/*
Задача 22: 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите целое число");
bool isParsed = int.TryParse(Console.ReadLine(), out int N);


Console.WriteLine($"N = {N}");

if (!isParsed)
{
Console.WriteLine("Вы ввели некорректные символы");

}

 int[] result = GetSqrtToN(N);

 PrintArray(result);

 void PrintArray (int[] arr) {

    for (int i = 0; i < arr.Length; i ++)
    Console.Write($"{arr[i]} ");
 }

int[] GetSqrtToN(int N) {
int[] arr = new int[N];
    for (int i = 0; i < N; i ++) {
    
    arr[i] = (int)(Math.Pow(i+1, 2));
    }
    return arr;
}
