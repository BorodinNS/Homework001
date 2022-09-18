Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
if(num%2 == 0)
{
    Console.WriteLine("Число четноё");
}
else
{
    Console.WriteLine("Число нечетное");
}