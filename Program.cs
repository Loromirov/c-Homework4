/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] numbers = new int[8];
Random rnd = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next();
}
Console.Write("[");
for (int i = 0; i < numbers.Length; i ++)
    Console.Write(numbers[i]+(i < numbers.Length - 1 ? ", " : ""));
Console.Write("]");