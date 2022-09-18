Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 == num2)
{
    Console.WriteLine("Числа равны");
}
else if (num1>num2)
{
    Console.WriteLine("Max " + num1);
    Console.WriteLine("Min " + num2);
}
else
{
    Console.WriteLine("Max " + num2);
    Console.WriteLine("Min " + num1);
}