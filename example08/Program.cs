Console.Clear();
Console.WriteLine("Введите число:");
int numA = int.Parse(Console.ReadLine()!);
if (numA%7==0 & numA%23==0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("НЕ кратно");
}