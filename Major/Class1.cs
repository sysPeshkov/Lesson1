namespace Major;
public class Class1
{
    public static class Helper
    {
        public static int InputNumber(string name)
        {
            Console.WriteLine(name);
            string number = Console.ReadLine();
            bool isParsed = int.TryParse(number, out int result);

            if (!isParsed)
            {
                Console.WriteLine($"Вы ввели некорректное число, ожидается целое число, вы ввели {number}");
                return -1;
            }
            return result;
        }
        public static void Print2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                   Console.Write($"{array[i,j]}  ");
                }
            Console.WriteLine("");
            }
        }


    }
}