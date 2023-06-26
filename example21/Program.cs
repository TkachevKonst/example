// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
Console.Clear();
Console.WriteLine("Введите числа через пробел");
string element = Console.ReadLine();
int[] arr1 = GetArray(element);
int[] multi = NumberMulti (arr1);

Console.WriteLine(String.Join(", ", arr1));
Console.WriteLine();
Console.WriteLine(String.Join(", ", multi));




int[] GetArray(string arr)
{
    string[] array = arr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] num = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        num[i] = int.Parse(array[i]);
    }
    return num;
}
int[] NumberMulti(int[] arr)
{int size = (arr.Length + 1) / 2;
    int[] array = new int[size];
    for (int i = 0; i < arr.Length / 2; i++)
    {
array[i] = arr[i] * arr[arr.Length-i-1]; 
    }
    if (arr.Length%2==1)
    {
        array[size-1] = arr[arr.Length/2];
    }
return array;
}