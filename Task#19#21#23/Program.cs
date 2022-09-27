// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
void Zadacha19Array()
{
    int [] array = {3, 6, 1, 6, 3,};
    int n = array.Length;
    if (n != 5)
    {
        Console.WriteLine("Введите пятизначное число");
    }
    else if (array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}

void Zadacha19()
{
    Console.WriteLine("Введите пятизначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 9999 && num < 100000)
    {
        int num5 = num % 10;
        int num4 = num / 10 % 10;
        int num3 = num / 100 % 10;
        int num2 = num / 1000 % 10;
        int num1 = num / 10000 % 10;
        Console.WriteLine($"|{num}|, |{num1}|, |{num2}|, |{num3}|, |{num4}|, |{num5}|");
        if (num5 == num1 && num4 == num2)
        {
            Console.WriteLine($"|{num}| является палиндромом");
        }
        else
        {
            Console.WriteLine($"|{num}| не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Число не пятизначное");
    }
    
}


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
void Zadacha21()
{
    Console.WriteLine("Введите x1: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите y1: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите z1: ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите x2: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите y2: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите z2: ");
    int z2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Точки: А({x1}, {y1}, {z1}), B({x2}, {y2}, {z2})");
    Console.WriteLine($"Расстояние между точками A и B: {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2))}");
                
}

// Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

void Zadacha23()
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    double Sqw;
    while (i <= num)
    {
        Sqw = Math.Pow(i, 3);
        Console.WriteLine($"|{i}|{Sqw}|");
        i++;
    }
}


//Zadacha19Array();
//Zadacha19();
//Zadacha21();
//Zadacha23();