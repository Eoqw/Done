using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}:");
        PrintNaturalNumbers(m, n);

        Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
    }

    static void PrintNaturalNumbers(int start, int end)
    {
        if (start <= end)
        {
            Console.WriteLine(start);
            PrintNaturalNumbers(start + 1, end);
        }
    }
}