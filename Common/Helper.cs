﻿// See https://aka.ms/new-console-template for more information
namespace Common;

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
    }