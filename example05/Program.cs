Console.Clear();
Console.Write("Введите расстояние в метрах:");
int metr = int.Parse (Console.ReadLine());
int friend = 2;
Console.Write("Введите скорость собаки:");
int sdog = int.Parse (Console.ReadLine());
Console.Write("Введите скорость друга 1:");
int sf1 = int.Parse (Console.ReadLine());
Console.Write("Введите скорость друга 2:");
int sf2 = int.Parse (Console.ReadLine());
int count = 0;
while (metr > 10)
{
    if (friend == 2)
    {
        int time = metr/(sdog+sf2);
        int friend = 1;
    }
    else
    {
        int time = metr/(sdog+sf1);
        int friend = 2;
    }
    int metr = metr-(sf1+sf2)*time;
    int count = count+1;
}
Console.WriteLine($"Собака пробежала {count} раз");