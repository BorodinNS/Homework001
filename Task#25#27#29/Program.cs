// Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход 
// два натуральных числа (A и B) и возводит число A в степень B.
void Zadacha25()
{
    Console.WriteLine("Введите число A: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int B = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
        Console.WriteLine(result);
    }
    Console.WriteLine($"Число {A} в степени {B} равняется: {result}");
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Zadacha27()
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int current = num;
    int count = 0;
    int sum = 0;
    while (current > 0)
    {
        sum = sum + (current%10);
        current = current / 10;
        count++;
    }
    Console.WriteLine($"Сумма цифр в числе {num} = {sum}");
}

// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
// и выводит отсортированный по модулю массив.
void FillArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(-100, 100);
    }
}

void Zadacha29()
{
    int size = 8;
    int[] numbers = new int[size];
    int temp;
    FillArray(numbers);
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (Math.Abs(numbers[i]) > Math.Abs(numbers[j]))
            {
                temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
        }
    }
    Console.WriteLine("Вывод отсортированного массива");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"| {numbers[i]} | ");
    }
   
}


// Zadacha25();
// Zadacha27();
// Zadacha29();