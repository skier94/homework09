//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Задайте значение m ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение n ");
int b = int.Parse(Console.ReadLine());

int Aker(int i, int j)
{
    if (i == 0) return j + 1;
    if (i != 0 && j == 0) return Aker(i - 1, 1);
    if (i > 0 && j > 0) return Aker(i - 1, Aker(i, j - 1));
    return Aker(i, j);
}

Console.WriteLine(Aker(a, b));