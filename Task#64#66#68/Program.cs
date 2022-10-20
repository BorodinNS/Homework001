void FindDiv3(int n, int counter)
{
    if (counter % 3 == 0)
    {
        Console.WriteLine(counter);
    }
    if (counter < n)
    {
        counter++;
    }
    else
    {
        return;
    }
    FindDiv3(n, counter);
}

int SumMN(int m, int n)
{
    int sum = 0;
    if (m == n)
    {
        Console.WriteLine($"Сумма элементов в промежутке равна {m}");
        return m;
    }

    if (m < n)
    {
        while (m <= n - 1)
        {
            Console.Write($"{m}, ");
            sum = sum + m;
            m++;
        }
        if (m == n)
        {
            Console.WriteLine($"{m}");
            sum = sum + m;
        }
    }

    if (n < m)
    {
        while (n <= m - 1)
        {
            Console.Write($"{n}, ");
            n++;
            sum = sum + n;
        }
        if (n == m)
        {
            Console.WriteLine($"{n}");
            sum = sum + n;
        }
    }
    return sum;
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

void Zadacha64()
// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
{
    Console.WriteLine("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int counter = m;
    Console.WriteLine($"Числа в отрезке от {m} до {n} кратные трём:");
    FindDiv3(n, counter);
}

void Zadacha66()
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
{
    Console.WriteLine("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = SumMN(m, n);
    Console.WriteLine($"Сумма элементов равна {sum}");

}

void Zadacha68()
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
{
    Console.WriteLine("Введите неотрицательное число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите неотрицательное число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int result = Akkerman(m, n);
    Console.WriteLine($"A({m},{n}) = {result}");
}



// Zadacha64();
//Zadacha66();
//Zadacha68();