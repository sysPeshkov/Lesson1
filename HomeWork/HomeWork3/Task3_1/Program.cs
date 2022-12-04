/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да
*/

int number = Input();

int[] revArray = new int[5];
int[] array = new int[5];

revArray = ReverseParseToArray(number);
array = ReverseArray(revArray);

bool isPolindrom = isPolindroms(array, revArray);
if (isPolindrom == false) {
    Console.WriteLine($"Нет, число {number} не полиндром");
}
else {
    Console.WriteLine($"Да, число {number} полиндром");
}


 bool isPolindroms(int[] array1, int[] array2) {
 bool result = true;
for (int i = 0; i < array1.Length; i++) {
    if (array1[i] != array2[i]){
    result = false;
    return result;
    }
    }
    return result;

 }


int[] ReverseArray(int[] array){
    int[] resultArray = new int[5];
    int length = array.Length;
    for (int i = 0; i < length; i++) {
    resultArray[i] = array[length- 1 -i];
    Console.Write(resultArray[i]);

    }
    Console.WriteLine(" ");
return resultArray;
}

int[] ReverseParseToArray(int num){
    int[] array = new int[5];
    for (int i = 0; i < 5; i++) {
    array[i] = num%10;
    num = num/10;
    Console.Write(array[i]);

    }
Console.WriteLine(" ");
//Console.WriteLine(array);
return array;
}


int Input() {
Console.WriteLine("Введите последовательность чисел ");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed) {
                Console.WriteLine("Вы ввели некорректное число ");
                return -1;
                }
                else {
                    return number;
                }

}
