Console.WriteLine("Введите целое число, которое больше 0: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
if(num<=0) Console.WriteLine("Некорректное число, введите число больше 0");
if(num == 1) Console.WriteLine("В заданном диапозоне нет четных чисел");
else
while(num>count)
{
    Console.Write(count + " ");
    count = count + 2;
}
