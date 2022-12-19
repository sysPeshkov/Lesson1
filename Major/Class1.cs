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
                    Console.Write($"{array[i, j]}  ");
                }
                Console.WriteLine("");
            }
        }
        public static int[] FillArray(int length)
        {
            int[] resultArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                //Console.Write($"Введите элемент массива {i+1}");
                resultArray[i] = InputNumber($"Введите элемент массива {i}");
            }
            return resultArray;
        }

        public static int[,] Fill2DArray(int m, int n)
        {
            int[,] resultArray = new int[m, n];

            for (int i = 0; i < resultArray.GetLength(0); i++)
            {
                for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    resultArray[i, j] = InputNumber($"Введите элемент массива {i}, {j}"); ;
                }

            }
            return resultArray;
        }
         public static int[,] Generate2DArray(int m, int n)
        {
            int[,] resultArray = new int[m, n];
            Random random = new Random();
            for (int i = 0; i < resultArray.GetLength(0); i++)
            {
                for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    resultArray[i, j] = random.Next(int.MinValue, int.MaxValue) ;
                }

            }
            return resultArray;
        }
    }
}