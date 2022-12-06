/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3 78 -> 2 89126 -> 5
*/

string number = Input();

int[] revArray = ReverseParseToArray(number);
Console.WriteLine(revArray.Length);

int[] ReverseParseToArray(string num){
    int a = int.Parse(num);
    int[] array = new int[num.Length];
    for (int i = 0; i < num.Length; i++) {
    array[i] = a%10;
    a = a/10;

    }
Console.WriteLine(" ");
//Console.WriteLine(array);
return array;
}

string Input() {
Console.WriteLine("Введите число ");
string number = Console.ReadLine();
return number;
//Не понимаю как адекватно можно написать
// bool isParsed = int.TryParse(Console.ReadLine(), out string number);
// if (!isParsed) {
//                 Console.WriteLine("Вы ввели некорректное число ");
//                 return "-1";
//                 }
//                 else {
//                     return number;
//                 }

}