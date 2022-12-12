/*
    Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12
*/

int NumberLength(int number)
{
    int index = 0;
    while (number > 0)
    {
        number /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int number, int length)
{
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine(sum);
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int length = NumberLength(number);
SumNumbers(number, length);