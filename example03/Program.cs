Console.Clear();
Console.Write("Ведите имя :");
string name = Console.ReadLine()!;
if (name.ToLower() == "костя")
{
    Console.WriteLine($"Привет, Костян!!!");
}
else
{
    Console.WriteLine($"Привет, {name}!!!");
}