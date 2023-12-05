using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10];

        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }

        Console.WriteLine("Массив чисел: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        int count = 0;

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество четных чисел в массиве: " + count);
    }
}