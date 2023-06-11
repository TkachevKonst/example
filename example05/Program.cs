Console.Clear();
Console.Write("Введите расстояние в метрах:");
int m = Convert.ToInt32(Console.ReadLine());
int f = 2;
int t = 0;
Console.Write("Введите скорость собаки:");
int sdog = int.Parse (Console.ReadLine());
Console.Write("Введите скорость друга 1:");
int sf1 = int.Parse (Console.ReadLine());
Console.Write("Введите скорость друга 2:");
int sf2 = int.Parse (Console.ReadLine());
int c = 0;
while (m > 10)
{
    if (f == 2)
    {
        t = m/(sdog+sf2);
        f = 1;
    }
    else
    {
        t = m/(sdog+sf1);
        f = 2;
    }
    m = m-(sf1+sf2)*t;
    c++;
}
Console.WriteLine($"Собака пробежала {c} раз");