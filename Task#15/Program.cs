//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num>7) Console.WriteLine("Введите цифру от 1 до 7");
if(num == 1 || num == 2 || num == 3 || num == 4 || num == 5) 
    {
        Console.WriteLine("Будний день");
    }
else if (num == 6 || num == 7)
{
    Console.WriteLine("Выходной день");
}