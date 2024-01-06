using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string[] inputArray = Console.ReadLine().Split(',');

        if (inputArray.Length == 1 && string.IsNullOrEmpty(inputArray[0].Trim()))
        {
            Console.WriteLine("Введен пустой массив.");
            return;
        }

        string[] outputArray = new string[inputArray.Length];
        int outputIndex = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Trim().Length <= 3)
            {
                outputArray[outputIndex] = inputArray[i].Trim();
                outputIndex++;
            }
        }

        Array.Resize(ref outputArray, outputIndex);

        Console.WriteLine("Новый массив:");
        Console.WriteLine(string.Join(", ", outputArray));
    }
}