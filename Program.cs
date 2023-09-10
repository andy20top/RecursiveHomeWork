﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int SetNumber(string msg)
{
    Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string RangeNumber (int startNum, int endNum = 1)
{
    if (startNum == endNum)
    {
        return endNum.ToString();
    }
    return $"{startNum} {RangeNumber(startNum-1, endNum)}"; 
}

int number = SetNumber("Enter number");
Console.WriteLine(RangeNumber(number));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int RangeSum(int firstNum, int secondNum)
{
    if (firstNum == secondNum)
    {
        return secondNum;
    }
    return firstNum + RangeSum(firstNum+1, secondNum);
}

int sum = RangeSum(1, 15);
System.Console.WriteLine(sum);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m-1, 1);
    }
    return Akkerman(m-1, Akkerman(m, n-1));
}

int num = Akkerman(2, 1);
Console.WriteLine(num);