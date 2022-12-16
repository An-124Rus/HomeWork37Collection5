using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int minNumberValue = 0;
        int maxNumberValue = 10;
        int firstArrayLength = 5;
        int secondArrayLength = 5;

        int[] firstArray = new int[firstArrayLength];
        int[] secondArray = new int[secondArrayLength];
        List<int> сollection = new List<int>();

        Console.WriteLine("Первый массив");
        CreateCollection(firstArray, firstArrayLength, minNumberValue, maxNumberValue);

        Console.WriteLine("\nВторой массив");
        CreateCollection(secondArray, secondArrayLength, minNumberValue, maxNumberValue);

        Console.WriteLine("\nКоллекция");
        CreateCollection(firstArray, сollection);
        CreateCollection(secondArray, сollection);
        ShowCollection(сollection);
    }

    static void CreateCollection(int[] array, int arrayLength, int minValue, int maxValue)
    {
        Random random = new Random();

        for (int i = 0; i < arrayLength; i++)
        {
            int number = random.Next(minValue, maxValue);

            array.SetValue(number, i);
        }

        foreach(var number in array)
            Console.Write(number + " ");

        Console.WriteLine();
    }

    static void CreateCollection(int[] array, List<int> collection)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (collection.Contains(array[i]) == false)
                collection.Add(array[i]);
        }
    }

    static void ShowCollection(List<int> collection)
    {
        collection.Sort();

        foreach (int number in collection)
            Console.Write(number + " ");
    }
}