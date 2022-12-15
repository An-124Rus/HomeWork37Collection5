using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        int minNumberValue = 0;
        int maxNumberValue = 10;
        int firstCollectionLength = 5;
        int secondCollectionLength = 5;

        List<int> firstCollection = new List<int>();
        List<int> secondCollection = new List<int>();
        List<int> newCollection = new List<int>();

        Console.WriteLine("Первая коллекция");
        CreateCollection(firstCollection, firstCollectionLength, minNumberValue, maxNumberValue);

        Console.WriteLine("\nВторая коллекция");
        CreateCollection(secondCollection, secondCollectionLength, minNumberValue, maxNumberValue);

        Console.WriteLine("\nНовая коллекция");
        CreateNewCollection(firstCollection, newCollection);
        CreateNewCollection(secondCollection, newCollection);

        newCollection.Sort();

        foreach (int number in newCollection)
            Console.Write(number + " ");
    }

    static void CreateCollection(List<int> collection, int collectionLength, int minValue, int maxValue)
    {
        Random random = new Random();

        for (int i = 0; i < collectionLength; i++)
        {
            int number = random.Next(minValue, maxValue);

            collection.Add(number);
        }

        foreach (int number in collection)
            Console.Write(number + " ");

        Console.WriteLine();
    }

    static void CreateNewCollection(List<int> collection, List<int> newCollection)
    {
        for (int i = 0; i < collection.Count; i++)
        {
            if (newCollection.Contains(collection[i]) == false)
            {
                newCollection.Add(collection[i]);

                if (i >= 0)
                    i--;
            }
        }
    }
}