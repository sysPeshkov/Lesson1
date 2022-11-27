// See https://aka.ms/new-console-template for more information
Random random = new Random();
int number = random.Next(100, 1000);

int firstNumber = number / 100;
int lastNumber = number % 10;
int Result =firstNumber*10+lastNumber;
Console.WriteLine(number);
Console.Write(Result);


int debt = lastNumber % firstNumber;
if ( debt == 0) {
Console.WriteLine(debt);
}