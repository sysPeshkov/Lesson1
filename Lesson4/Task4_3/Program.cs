// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] num = GenerateArray();
PrintArray(num);

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}");
    }
    
    }

int[] GenerateArray(){
int[] result = new int[8];
Random rand = new Random();
for (int i = 0; i < result.Length; i++) {
    result[i] = rand.Next(0,2);

}
return result;
}