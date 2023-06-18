Console.Clear();
Console.WriteLine("Введите два числа:");
int numA = int.Parse(Console.ReadLine()!);
int numB = int.Parse(Console.ReadLine()!);
int numC = numB%numA;
if (numC==0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"Остаток от деления = {numC}");
}