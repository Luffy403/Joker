using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 3, 2, 3, 4, 3, 5, 2, 1, 2, 2};
        int mostFrequent = Mostnumber(numbers);
        Console.WriteLine("Часто встречающийся элемент: " + mostFrequent);
        Console.ReadKey();
    }

    static int Mostnumber(int[] array)
    {
        int mostFrequent = array[0];
        int maxCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                mostFrequent = array[i];
            }
        }

        return mostFrequent;
    }
}