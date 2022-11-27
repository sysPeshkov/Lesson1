// See https://aka.ms/new-console-template for more information
Random random = new Random();
int number = random.Next(100, 1000);

int firstNumber = number / 100;
int lastNumber = number % 10;
int Result = (firstNumber*10) + lastNumber;
Console.Write("number = ");
Console.WriteLine(number);
Console.Write("Result = ");
Console.WriteLine(Result);

int debt = lastNumber % firstNumber;
Console.Write("debt = ");
Console.WriteLine(debt);
if ( debt == 0) {
Console.WriteLine("Кратно");
Console.WriteLine(debt);
}