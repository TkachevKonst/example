using System;
using static System.Console;
Clear();
/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/
string[] array = { "hello", "friend", "end", "matrix", "35", "365", "yes" };
int size = СounterArray(array);
string[] newArray = NewArray(array, size);
Write($"В массиве [{String.Join(", ", array)}],\n количество элементов длина которых меньше, либо равна 3 символам равно {size}.\n Новый массив [{String.Join(", ", newArray)}]");

string[] NewArray(string[] arr, int count)
{
    string[] newArr = new string[count];
    int newCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[newCount] = arr[i];
            newCount++;
        }
    }
    return newArr;
}

int СounterArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {

        Write(arr[i]+ ", ");

    }
}