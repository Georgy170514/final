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


