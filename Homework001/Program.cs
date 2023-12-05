using System;

class Program
{
    static void Main(string[] args)
    {
        bool isEvenSum = false;

        while (!isEvenSum)
        {
            Console.Write("Введите целое число (для выхода введите 'q'): ");
            string input = Console.ReadLine();

            if (input == "q")
            {
                Console.WriteLine("Выход из программы.");
                break;
            }

            int number;
            if (int.TryParse(input, out number))
            {
                int sum = 0;
                int tempNumber = Math.Abs(number);

                while (tempNumber > 0)
                {
                    sum += tempNumber % 10;
                    tempNumber /= 10;
                }

                if (sum % 2 == 0)
                {
                    isEvenSum = true;
                    Console.WriteLine("Сумма цифр числа {0} является четной. Программа завершена.", number);
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте ещё раз.");
            }
        }
    }
}