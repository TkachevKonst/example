Console.Clear();
Console.Write ("Введите первое число :");
int numA = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число :");
int numB = int.Parse(Console.ReadLine());
if (Math.Pow(numB,2)==numA)
{
    Console.WriteLine ("Да");
}
else
{
    Console.WriteLine ("Нет");
}