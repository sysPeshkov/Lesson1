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
        public static int[,] Generate2DArray(int m, int n, int min, int max)
        {
            int[,] resultArray = new int[m, n];
            Random random = new Random();
            for (int i = 0; i < resultArray.GetLength(0); i++)
            {
                for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    resultArray[i, j] = random.Next(min, max);
                }

            }
            return resultArray;
        }

        public static int[,] Copy2DArray(int[,] array)
        {
            int numberRows = array.GetLength(0);
            int numberColumns = array.GetLength(1);
            int[,] resultArray = new int[numberRows, numberColumns];

            for (int i = 0; i < resultArray.GetLength(0); i++)
            {
                for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    resultArray[i, j] = array[i, j];
                }

            }
            return resultArray;
        }

        public static void MaxNumberAndIndexInArray(int[] array, out int maxVaue, out int maxIndexValue)
        {
            int length = array.Length;
            maxVaue = array[0];
            maxIndexValue = 0;

            for (int i = 0; i < length; i++)
            {
                if (array[i] > maxVaue)
                {
                    maxVaue = array[i];
                    maxIndexValue = i;
                }
            }
        }

        public static void FindNumberInArray(int[,] array, int number)
        {
            int finded = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == number)
                    {
                        finded = 1;
                        break;
                    }
                }

            }

            if (finded == 1)
            {
                Console.WriteLine($"Элемент {number} найден");
            }
            else { Console.WriteLine($"{number} -> такого числа в массиве нет"); }
        }

        public static double[] GetAverageInColumns(int[,] array)
        {
            int[] arrayColumn = new int[array.GetLength(0)];
            double[] resultArray = new double[array.GetLength(1)];

            for (int i = 0; i < array.GetLength(1); i++) //Проходи по колонкам
            {
                for (int j = 0; j < array.GetLength(0); j++) //Проходи по строкам
                {
                    arrayColumn[j] = array[j, i];
                }
                resultArray[i] = GetAverage(arrayColumn);
            }
            return resultArray;
        }

        public static double GetAverage(int[] array)
        {
            double result = 0;
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                result += array[i];
            }
            result = result / length;
            return result;
        }
        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
        }

        public static void PrintArrayInt(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
        }

    
        public static void FindNumberInArray(int number, int[] array)
        {
            bool finded = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    finded = true;

                    break;
                }
            }
            if (finded = false)
            {
                Console.WriteLine("Нет");
            }
            else { Console.WriteLine("Да"); }
        }
    }
}