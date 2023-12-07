using System;

class Program
{
    static void Main()
    {
        // Произвольный массив
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReversed(array, array.Length - 1);

        Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
    }

    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReversed(arr, index - 1);
        }
    }
}