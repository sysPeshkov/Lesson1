// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Поиск числа в массиве
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
