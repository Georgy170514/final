using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве: ");
        int n = int.Parse(Console.ReadLine());

        
        string[] inputArray = new string[n];

       
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите значение {i + 1}: ");
            inputArray[i] = Console.ReadLine();
        }

        
        string[] resultArray = FilterStrings(inputArray);

                Console.WriteLine("Результирующий массив: [" + string.Join(", ", resultArray) + "]");
    }

    static string[] FilterStrings(string[] inputArray)
    {
        
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];

        
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }
}


