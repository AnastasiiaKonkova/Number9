// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
/*
void NumberToN(int num)
{
    Console.Write(num + ", ");
    if (num > 0) NumberToN (num - 1);
    else if (num < 0) NumberToN (num + 1);
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
NumberToN(n);
Console.Write("1.");
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*

int SumNtoM(int m, int n)
{
    if(m < n) return SumNtoM(m,n-1)+n;
    if(m > n) return SumNtoM(n,m-1)+m;
    else return m;
}

Console.Write("Input a namber M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a namber N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {m}; N = {n} -> {SumNtoM(m, n)}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29