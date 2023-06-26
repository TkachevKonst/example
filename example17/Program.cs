Console.Clear();
Console.Write("Введите любое число :");
int number = int.Parse(Console.ReadLine()!);
int quanNumber = QuanNumber(number);
Console.WriteLine(quanNumber);
int QuanNumber(int num)
{
    int sum = 0;
    while (num != 0)
    {
        num = num / 10;
        sum = sum + 1;
    }
    return sum;
}