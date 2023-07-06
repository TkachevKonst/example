// **Задача 53:**Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2*/
using System;
using static System.Console;
Clear();
Write("Введите кличество строк:");
int row = int.Parse(ReadLine());
Write("Введите кличество cтолбцов:");
int collums = int.Parse(ReadLine());
int[,] matrix = new int[row, collums];
GetArray(matrix, 0, 9);
PrintArray(matrix);
WriteLine();
ChanchArray1(matrix);
PrintArray(matrix);
WriteLine();
PrintArray(ChanchArray2(matrix));
WriteLine();
int[] arr1 = GetRowArray(matrix);
WriteLine($"{String.Join (" ", arr1)}");
SortingRowArray(arr1);
WriteLine();
WriteLine($"{String.Join (" ", arr1)}");
CounterNumber(arr1);
WriteLine();
Write("Введите какие строки поменять через пробел");
string chanch = (ReadLine());
int[] chanchnew = GetArr(chanch);
ChanchRow(matrix, chanchnew[0], chanchnew[1]);
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
void ChanchRow(int[,] array, int a, int b)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int n = array[a - 1, i];
        array[a - 1, i] = array[b - 1, i];
        array[b - 1, i] = n;
    }
}
int[] GetArr(string arr)
{
    string[] array = arr.Split(" ");
    int[] arr1 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr1[i] = int.Parse(array[i]);
    }
    return arr1;
}
// **Задача 55:**Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
void ChanchArray1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            if (array.GetLength(0) == array.GetLength(1))
            {
                int n = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = n;
            }
            else
            {
                WriteLine("Невозможно произвести операцию");
                return;
            }
        }
    }
}
int[,] ChanchArray2(int[,] array)
{
    int[,] array1 = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array1[j, i] = array[i, j];
        }
    }
    return array1;
}
// /* **Задача 57:**Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3,4, 6, 1, 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
int[] GetRowArray(int[,] array)
{
    int[] rezult = new int[array.GetLength(0) * array.GetLength(1)];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rezult[index] = array[i, j];
            index++;
        }
    }
    return rezult;
}
void SortingRowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                int n = array[j];
                array[j] = array[j + 1];
                array[j + 1] = n;
            }
        }
    }
}
void CounterNumber(int[] array)
{
    int el = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (el == array[i])
        {
            count++;
        }
        else
        {
            WriteLine($"{el} встречается {count}");
            el = array[i];
            count = 1;
        }
    }
    WriteLine($"{el} встречается {count}");
}