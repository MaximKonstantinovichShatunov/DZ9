/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
Console.WriteLine("Введите натуральное число N");
int n = int.Parse(Console.ReadLine());
if (n < 0)
{
    Console.WriteLine("Вы ввели не натуральное число");
}
void PrintNamber(int n)
{
    if (n > 0)
    {
        if (n > 1) Console.Write(n + ", ");
        else Console.WriteLine(n);
        PrintNamber(n - 1);
    }
}
Console.WriteLine();
PrintNamber(n);

