// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
Console.Clear();
int [] array = GetArray (123, 0, 1000);
int number = Number(array, 9, 100);
Console.WriteLine (String.Join(" ", array));
Console.WriteLine ($" Количество двухзначных чисел = {number}");
int[] GetArray(int size, int right, int left)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(right, left + 1);
    }
return arr;
}
int Number (int[]arr, int rigth,int left)
{int count =0;
foreach (int el in arr)
{
    if (el>rigth && el<left)
    {
        count++;
    }
}
return count;
}