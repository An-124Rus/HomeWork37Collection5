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
        AddValueInArray(firstArray, firstArrayLength, minNumberValue, maxNumberValue);

        Console.WriteLine("\nВторой массив");
        AddValueInArray(secondArray, secondArrayLength, minNumberValue, maxNumberValue);

        Console.WriteLine("\nКоллекция");
        AddValueInCollection(firstArray, сollection);
        AddValueInCollection(secondArray, сollection);
        ShowCollection(сollection);
    }

    static void AddValueInArray(int[] array, int arrayLength, int minValue, int maxValue)
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

    static void AddValueInCollection(int[] array, List<int> collection)
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