void FillArray(int[,] num)
{
    Random random = new Random();
    int rows = num.GetLength(0);
    int columns = num.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            num[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArray(int[,] num)
{
    int rows = num.GetLength(0);
    int columns = num.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(num[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SelectionSort(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            for (int k = 0; k < num.GetLength(1) - 1; k++)
            {
                if (num[i, k] < num[i, k + 1])
                {
                    int temp = num[i, k + 1];
                    num[i, k + 1] = num[i, k];
                    num[i, k] = temp;
                }
            }
        }
    }
}

void MinSum(int[,] numbers)
{
    int[] num = new int[numbers.GetLength(0)];
    
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum += numbers[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} элемента равна: {sum}");
        num[i] = sum;
    }
    int minValue = num[0];
    int minIndex = 1;
    for (int i = 1; i < num.Length; i++)
    {
        if (minValue > num[i])
        {
            minValue = num[i];
            minIndex = i + 1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minIndex}");
}

void Zadacha54()
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
{
    Random random = new Random();
    int rows = random.Next(4, 6);
    int columns = random.Next(4, 6);
    Console.WriteLine($"Массив размера {rows} строк {columns} столбцов");
    int[,] num = new int[rows, columns];
    FillArray(num);
    PrintArray(num);
    SelectionSort(num);
    Console.WriteLine();
    PrintArray(num);
}

void Zadacha56()
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
{
    Random random = new Random();
    int rows = random.Next(4, 6);
    int columns = random.Next(4, 6);
    Console.WriteLine($"Массив размера {rows} строк {columns} столбцов");
    int[,] num = new int[rows, columns];
    FillArray(num);
    PrintArray(num);
    MinSum(num);
}


// Zadacha54();
// Zadacha56();