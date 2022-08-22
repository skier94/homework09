//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Задайте значение m ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение n ");
int b = int.Parse(Console.ReadLine());

string Print(int i, int j)
{
    string s = "";
    if (j == i - 1) return s;
    return (Print(i, j - 1) + j).ToString();
}

Console.WriteLine(Print(a, b));