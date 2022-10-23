// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] InputFromConsoleArray()
{
    Console.Write("Введите сколько чисел будет в массиве: ");
    int sizeArray = int.Parse(Console.ReadLine());
    int[] arr = new int[sizeArray];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
            Console.Write($"{arr[i]}");
        else
            Console.Write($"{arr[i]}, ");
    }
}

int FindCountPositiveNumsInArray(int[] arr)
{
    int resultCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            resultCount++;
    }
    return resultCount;
}


int[] arr = InputFromConsoleArray();
PrintArray(arr);
int countPositiveNumsInArray = FindCountPositiveNumsInArray(arr);
Console.WriteLine();
Console.WriteLine($"В массиве чисел больше нуля: {countPositiveNumsInArray}");
