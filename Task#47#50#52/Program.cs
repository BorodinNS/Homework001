void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(-10, 11);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void AverageColumn(int[,] FindInd)
{
    int rows = FindInd.GetLength(0);
    int columns = FindInd.GetLength(1);
    double averSum = 0;
    for (int j = 0; j < columns; j++)
    {   
        double Sum = 0;
        for (int i = 0; i < rows; i++)
        {
            Sum +=FindInd[i, j]; 
        }
        Console.Write("");
        averSum = Math.Round(Sum / rows, 1);
        Console.WriteLine($"Среднее арифметическое {j+1} столбца = {averSum}");
    }
}

void Zadacha47()
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}x{columns}");
    double[,] numbers = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(-10, 11) + random.NextDouble();
        }
    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(Math.Round(numbers[i, j], 1) + "\t");
        }
        Console.WriteLine();
    }
}

void Zadacha50()
// Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows} строк {columns} столбцов");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Введите строку числа: ");
    int numRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите столбик числа: ");
    int numColumns = Convert.ToInt32(Console.ReadLine());
    if (numRows < rows && numColumns < columns)
    {
        Console.WriteLine($"Число с индексом {numRows}:{numColumns} = {numbers[numRows, numColumns]}");
    }
    else
    {
        Console.WriteLine("Введены некорректные значения");
    }
}

void Zadacha52()
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
{
    Random random = new Random();
    int rows = random.Next(4, 6);
    int columns = random.Next(4, 6);
    Console.WriteLine($"Массив размера {rows} строк {columns} столбцов");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    AverageColumn(numbers);
}
//Zadacha47();
//Zadacha50();
//Zadacha52();