using System.Collections.Generic;

List<int> numberList = new List<int>() { 8, 7, 5 };

int[] numberArray = new int[] { 1, 2, 3, 4 };

CollectionsSum(numberList);
CollectionsSum(numberArray);

static void CollectionsSum(IEnumerable<int> anyCollection)
{
    int sum = 0;

    foreach (int num in anyCollection)
    {
        sum += num;
    }

    Console.WriteLine("Sum is: {0}", sum);
}