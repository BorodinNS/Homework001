// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int tens;
if(num > 99 && num < 1000)
{
    tens = num / 10 % 10;
    Console.WriteLine(tens);
}
else     
{
    Console.WriteLine("Неккоректное число");
}