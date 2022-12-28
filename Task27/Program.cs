// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    System.Console.WriteLine("введите число");
    return int.Parse(Console.ReadLine());
}
int n = Prompt("Введите число");
int summ = 0;

while (n > 0)
{
    summ = summ + n % 10;
    n = n / 10;
}
System.Console.WriteLine(summ);




