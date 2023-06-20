Console.Clear();
Console.Write("Введите количество элементтов в массиве:");
int N = int.Parse(Console.ReadLine());
int[] arr = new int [N];
void FullAll (int[] collec)
{
int length = collec.Length;

for (int i = 0; i < length; i++)
{
     collec [i] = new Random().Next(1,100);
}
}
void Print (int[] arroy)
{
int length = arroy.Length;
for (int i = 0; i < length; i++)
{
    Console.Write($" {arroy[i]}");
}
}
int IndexOff (int[] arroy1, int num)
{
int position = -1;
    for (int i = 0; i < arroy1.Length; i++)
{
    if (arroy1[i]==num)
    {
      position = i; 
      break;
    }
}

    return position;
}
void Max (int[] arroy2)
{
int len = arroy2.Length;
for (int i = 0; i < len-1; i++)
{
    int indmax =i;
    for (int j = i+1; j < len; j++)
    {
        if (arroy2[j]>arroy2[indmax])
        {
            indmax = j;

    }
    }
    int temp = arroy2[i];
    arroy2[i] = arroy2[indmax];
    arroy2[indmax] = temp;
}
}
void Min (int[] arroy3)
{int len = arroy3.Length;
for (int i = 0; i < len-1; i++)
{
    int indmin =i;
    for (int j = i+1; j < len; j++)
    {
        if (arroy3[j]<arroy3[indmin])
        {
            indmin = j;

    }
    }
    int temp = arroy3[i];
    arroy3[i] = arroy3[indmin];
    arroy3[indmin] = temp;}
}
FullAll (arr);
Print (arr);
Console.WriteLine();
int pos = IndexOff (arr, 55);
Console.WriteLine(pos);
Max (arr);
Print (arr);
Console.WriteLine();
Min (arr);
Print (arr);