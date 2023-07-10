using System;
using static System.Console;
Clear();
/* **Задача 63:**Задайте значение N.Напишите программу,
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5-> "1, 2, 3, 4, 5"
N = 6-> "1, 2, 3, 4, 5, 6"
*/
// WriteLine("Введите число:");
// int n = int.Parse(ReadLine());
// WriteLine(NumberLine(n));

// string NumberLine (int num)
// {

// if (num==1)
// {
//     return "1";
// }
// string numberline = NumberLine(num-1) + ", " + num.ToString();
// return numberline;
// }
/*Задайте значения M и N.
Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.
*/
// WriteLine("Введите число:");
// int m1 = int.Parse(ReadLine());
// WriteLine("Введите число:");
// int n1 = int.Parse(ReadLine());
// WriteLine(NumberLineMN(m1,n1));

// string NumberLineMN (int num1, int num2)
// {

// if (num1==num2)
// {
//     return num2.ToString();
// }
// string numberline = num1.ToString() + ", "+ NumberLineMN (num1+1,num2);
// return numberline;
// }
// **Задача 69:**Напишите программу,
// которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8
WriteLine("Введите число которое возводим в степень:");
int a = int.Parse(ReadLine());
WriteLine("Введите степень:");
int e = int.Parse(ReadLine());
WriteLine(PowNumber(a,e));


int PowNumber (int num1, int num2)
{
if (num2 == 0)
{
    return 1;
}
int pownumber = num1 * PowNumber(num1,num2-1);
return pownumber;
}
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
WriteLine("Введите число:");
int number = int.Parse(ReadLine());
WriteLine(SumNumbers(number));

int SumNumbers (int num)
{
if (num==0)
{
    return 0;
}
int sum = num%10 + SumNumbers(num/10);
return sum;
}