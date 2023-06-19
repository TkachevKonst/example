Console.Clear();
Console.WriteLine("Введите координаты точки 1");
double x1 = double.Parse(Console.ReadLine()!);
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки 2");
double x2 = double.Parse(Console.ReadLine()!);
double y2 = double.Parse(Console.ReadLine()!);
double rez = Math.Sqrt(Math.Pow(x1-x2,2))+Math.Pow(y1-y2,2);
Console.WriteLine($"Ответ = {rez:f2}");