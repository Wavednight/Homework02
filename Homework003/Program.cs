﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 15,78,98,85,11 };

        Console.WriteLine("Исходный массив: ");
        PrintArray(array);

        ReverseArray(array);

        Console.WriteLine("Перевернутый массив: ");
        PrintArray(array);
    }

    static void ReverseArray(int[] array)
    {
        int start = 0;
        int end = array.Length - 1;

        while (start < end)
        {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;

            start++;
            end--;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}