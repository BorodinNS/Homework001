void FillArray(int[] numbers, int minValue = 0, int maxValue = 100)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] num)


{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + "\t");
    }
    Console.WriteLine();
}

void FindEvenNumber(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество четных чисел: {count}");
}

void SumOddNumber(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + numbers[i];
            Console.WriteLine($"{numbers[i]} | {sum})");
        }
    }
    Console.WriteLine($"Сумма чисел с нечетным индексом: {sum}");
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Zadacha34()
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 1000);
    PrintArray(numbers);
    FindEvenNumber(numbers);

}


// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void Zadacha36()
{
    {
        int size = 12;
        int[] numbers = new int[size];
        FillArray(numbers, -9, 9);
        PrintArray(numbers);
        SumOddNumber(numbers);
    }
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = - 2,71, difference = 80,95
void Zadacha38()
{

}

// Zadacha34();
// Zadacha36();