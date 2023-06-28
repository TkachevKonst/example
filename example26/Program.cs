Console.Clear();
// Console.Write("Введите длину массива :");
// int size = int.Parse(Console.ReadLine());
// Console.Write("Левую границу массива ");
// int left = int.Parse(Console.ReadLine());
// Console.Write("Правую границу массива ");
// int right = int.Parse(Console.ReadLine());
// int[] array = NewArray(size, left, right);
// Console.WriteLine($"[{String.Join(" ", array)}]");
// Reversiv(array);
// Console.WriteLine($"[{String.Join(" ", array)}]");
// int[] NewArray(int num, int min, int max)
// {
//     int[] arr = new int[num];
//     for (int i = 0; i < num; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1);
//     }
//     return arr;
// }
// void Reversiv(int[] arr)
// {
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         int k = arr[i];
//         arr[i] = arr[arr.Length - 1 - i];
//         arr[arr.Length - 1 - i] = k;
//     }
// }
Console.Write("Любое число :");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{number} в двоичнй системе = {Translit(number)}");
string Translit(int num)
{
    string sistem = String.Empty;
    while (num != 0)
    {
        int rez = num % 2;
        num /= 2;
        sistem = rez + sistem;
    }
    return sistem;
}