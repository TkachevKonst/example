Console.Clear();
Console.WriteLine("Введите координаты точки 1");
int x1 = int.Parse(Console.ReadLine()!);
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки 2");
int x2 = int.Parse(Console.ReadLine()!);
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Ответ = {Math.Sqrt(Math.Pow(x1-x2,2))+Math.Pow(y1-y2,2)}");