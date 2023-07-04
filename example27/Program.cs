//Задайте двумерный массив размером m×n,
//заполненный случайными целыми числами
using System;
using static System.Console;
Clear();
Write("Введите кличество строк:");
int row = int.Parse(ReadLine());
Write("Введите кличество cтолбцов:");
int collums = int.Parse(ReadLine());
int[,] matrix = new int[row, collums];
GetArray(matrix, 0, 10);
PrintArray(matrix);
WriteLine();
WriteLine($"Сумма главной диагонали = {SumDiagonal(matrix)}");
WriteLine();
SquaredMatrix(matrix);
PrintArray(matrix);
WriteLine();
GetArray1(matrix);
PrintArray(matrix);




void GetArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($" {array[i, j]}");
        }
        WriteLine();
    }
}
// **Задача 48:** Задайте
// двумерный массив размера m на n, каждый элемент
// в массиве находится по формуле: A[i, j] = i + j.
//Выведите полученный массив на экран.
void GetArray1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
}
// **Задача 49:**Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

void SquaredMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
}
// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся
// на главной диагонали (с индексами (0,0); (1; 1) и т.д.
int SumDiagonal(int[,]array)
{
int length = array.GetLength(0)<array.GetLength(1)? 
array.GetLength(0):array.GetLength(1);
int sum = 0;
for (int i = 0; i < length; i++)
{
 sum=sum + array[i,i];   
}
return sum;
}