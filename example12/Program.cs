﻿Console.Clear();
Console.WriteLine("номер четверти:");
int num1= int.Parse(Console.ReadLine()!);
switch (num1)
{
    case 1:{ 
    Console.WriteLine("x>0, y>0");
    break;}
    case 2:{ 
    Console.WriteLine("x<0, y>0");
    break;}
    case 3:{ 
    Console.WriteLine("x<0, y<0");
    break;}
    case 4:{ 
    Console.WriteLine("x>0, y<0");
    break;}
    default: {
        Console.WriteLine("Введено не правильно");
        break;
    }
}