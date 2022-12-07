/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int min;
int max;
if (m < n)
{
    min = m;
    max = n;
}
else
{
    min = n;
    max = m;
}
int Sum(int min, int max)
{
    int summa = 0;
    if( max>= min && max>0)
    {
        summa = max + Sum( min,max-1);
    }
        
    return summa;
}


Console.WriteLine("Результат: " + Sum(min, max));