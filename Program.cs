using System;

class Program
{
    // 1. Методы для работы с массивами
    // Метод сортировки массива по возрастанию
    public static int[] SortAscending(int[] array)
    {
        if (array == null || array.Length == 0)
            return array;

        int[] result = (int[])array.Clone();
        Array.Sort(result);
        return result;
    }
    // Метод сортировки массива по убыванию
    public static int[] SortDescending(int[] array)
    {
        if (array == null || array.Length == 0)
            return array;

        int[] result = (int[])array.Clone();
        Array.Sort(result);
        Array.Reverse(result);
        return result;
    }
    // Метод объединения двух массивов в один
    public static int[] MergeArrays(int[] array1, int[] array2)
    {
        if (array1 == null && array2 == null)
            return new int[0];

        if (array1 == null)
            return (int[])array2.Clone();

        if (array2 == null)
            return (int[])array1.Clone();

        int[] result = new int[array1.Length + array2.Length];
        Array.Copy(array1, result, array1.Length);
        Array.Copy(array2, 0, result, array1.Length, array2.Length);
        return result;
    }

    // 2. Метод для расчёта абсолютной разности
    public static int CalculateDifference(int n)
    {
        int difference = Math.Abs(n - 123);

        if (n > 123)
            return 3 * difference;

        return difference;
    }

    static void Main()
    {
        Console.WriteLine("1. Работа с массивами:");

        int[] arr1 = { 5, 2, 8, 1 };
        int[] arr2 = { 7, 3, 9 };

        Console.WriteLine("Исходный массив 1: " + string.Join(", ", arr1));
        Console.WriteLine("По возрастанию: " + string.Join(", ", SortAscending(arr1)));
        Console.WriteLine("По убыванию: " + string.Join(", ", SortDescending(arr1)));

        Console.WriteLine("Исходный массив 2: " + string.Join(", ", arr2));
        int[] merged = MergeArrays(arr1, arr2);
        Console.WriteLine("Объединённый массив: " + string.Join(", ", merged));

        Console.WriteLine("\n2. Расчёт абсолютной разности:");
        Console.Write("Введите целое число n: ");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int n))
        {
            int result = CalculateDifference(n);
            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Ошибка: введено не целое число.");
        }
    }
}
