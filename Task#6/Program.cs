Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
if(num%2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}