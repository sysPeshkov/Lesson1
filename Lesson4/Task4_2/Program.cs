// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24 5->120

int num = Input();
int product = GetProductOfNumbers(num);

Console.WriteLine(product);

Tests();



int GetProductOfNumbers(int N) {
int result = 1;
for (int i = 1; i <= N; i++) {
result = result * i;
}
return result;
}
int Input() {
 Console.WriteLine("Введите число:") ;  
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed) {
    Console.WriteLine("Вы ввели неккорекное число ");
    return -1;
}
else {
    return number;
}

}



void Tests(){
int[] input = {2, 3, 4, 5};
int[] expectedResult = {2, 6, 24, 120};
int length = input.Length;
for (int i = 0; i < length; i++)
{
    if (GetProductOfNumbers(input[i]) != expectedResult[i]) {
        Console.WriteLine($"Error. Expect = {expectedResult[i]}, result =  {GetProductOfNumbers(input[i])}");
    }
}
}