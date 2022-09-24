//Напишите программу, которая с помощью деления выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num<100)
{
    Console.WriteLine("Третьей цифры нет"); 
}
else
{
    while(num>999)
{
num = (num/10);
}
if (num<=999);
Console.WriteLine(num % 10);
}
