Console.Clear();
Console.WriteLine("Введите любое число");
int num1 = int.Parse(Console.ReadLine()!);
int[] rez = new int[num1];
for (int i = 1; i <= num1; i++)
{
    rez[i-1] = i*i;
}
for (int i = 0; i < num1; i++)
{
    Console.Write($" {rez[i]}");
}
Console.WriteLine();
for (int i = 1; i <= num1; i++)
{
   Console.Write($" {Math.Pow(i,2)}");
}
Console.WriteLine();