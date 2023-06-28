Console.Clear();
Console.WriteLine("Напишите три числа через пробел :");
string[] number = Console.ReadLine().Split(" ");
int num1 = int.Parse(number[0]);
int num2 = int.Parse(number[1]);
int num3 = int.Parse(number[2]);
if (IsTriagle(num1, num2, num3))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

bool IsTriagle(int a, int b, int c)
{
    return (((a + c) > b) && ((a + b) > c) && ((b + c) > a));

}