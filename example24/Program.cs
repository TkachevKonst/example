// факториал с циклом и рекурсией
Console.Clear();
Console.Write("Введите любое число :");
int n = int.Parse(Console.ReadLine());
int fac = 1;
//циклом
for (int i = 1; i <= n; i++)
{
    fac *= i;
}
Console.WriteLine($"Факториал числа {n} = {fac}");
// рекурсия
Console.WriteLine(Factorial(n));
int Factorial(int num)
{
    if (num == 1) return 1;
    else return num * Factorial(num - 1);
}
//Числа фибаначи
// циклом
Console.WriteLine($"[{String.Join(" ",Fibanachi(n))}]");
int[] Fibanachi(int num)
{
int[]fiban = new int[num];
fiban[0] = 0;
if (num>=2)
{
fiban[1]=1;
for (int i = 2; i < num; i++)
{
    fiban[i]=fiban[i-1]+fiban[i-2];
} 
}return fiban;
}
//Рекурсия
int Fib (int num)
{
if (num==1||num==2) return 1;
else return Fib(num-1) + Fib(num-2);
}
for (int i = 1; i < n; i++)
{
    Console.Write ($" {Fib(i)}");
}