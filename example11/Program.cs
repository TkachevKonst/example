Console.Clear();
Console.WriteLine("Введите координаты точки");
int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);
if (x>0 && y>0)
{
    Console.WriteLine("Точка находится в 1 четверти");
}else if (x<0 && y>0)
{
    Console.WriteLine("Точка находится в 2 четверти");
}else if (x<0 && y<0)
{
    Console.WriteLine("Точка находится в 3 четверти");
}else if (x>0 && y<0)
{
    Console.WriteLine("Точка находится в 4 четверти");
}