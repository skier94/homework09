//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Задайте значение m ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение n ");
int b = int.Parse(Console.ReadLine());

int Print(int i, int j)
{
    int s = j;
    if (j < i + 1) return s;
    return (s + Print(i, j - 1));
}

Console.WriteLine(Print(a, b));