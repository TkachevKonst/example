Console.Clear();
Console.WriteLine("Введите два числа:");
int numA = int.Parse(Console.ReadLine()!);
int numB = int.Parse(Console.ReadLine()!);
if (Math.Pow(numA,2)==numB || Math.Pow(numB,2)==numA)
{
    Console.WriteLine("Квадрат");
}else
{
    Console.WriteLine("не является квадратом");
}