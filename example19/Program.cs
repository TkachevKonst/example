Console.Clear();
Console.Write(" Введите любые числа через пробел :");
string num = Console.ReadLine();
Console.Write(" Введите число :");
int num1 = int.Parse (Console.ReadLine()!);
int[] array1 = GetArray(num);
if (NumberTrue(array1, num1))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
int[] GetArray (string arr)
{
string[] array = arr.Split(" ");
int[] rez = new int [array.Length];
for (int i = 0; i < array.Length; i++)
{
    rez[i] = int.Parse(array[i]);
} 
return rez;
}
bool NumberTrue (int[] array, int n)
{
foreach (int el in array)
{
    if (el==n)
    {
        return true;
    }
   }
    return false;
}